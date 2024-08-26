module uart_cmd_proc (
    input   wire    i_clk,
    input   wire    i_res_n,
    input   wire    i_uart_rx,
    input   wire    i_pps,

    output  reg     o_pps_sync_en
    );

    wire    [7:0]   w_uart_rx_data;
    wire            w_uart_rx_den;


    // UART RX
    uart_rx uart_rx_inst (
        .i_clk ( i_clk ),
        .i_rst_n ( i_res_n ),
        .i_uart_mosi ( i_uart_rx ),
        .o_data ( w_uart_rx_data[7:0] ),
        .o_dataen ( w_uart_rx_den )
    );

    // Command decoder
    reg     [15:0]  r_rx_buf;
    reg             r_sc_gate;
    always @(posedge i_clk or negedge i_res_n) begin
        if (~i_res_n) begin
            r_rx_buf[15:0] <= 16'd0;
            r_sc_gate <= 1'b0;
        end else begin
            if (w_uart_rx_den) begin
                r_rx_buf[15:0] <= {r_rx_buf[7:0], w_uart_rx_data[7:0]};

                // [LF]
                if (w_uart_rx_data[7:0] == 8'h0a) begin
                    if (r_rx_buf[15:0] == 16'h7363) begin   // sc
                        r_sc_gate <= 1'b1;
                    end
                end

            end else begin
                r_sc_gate <= 1'b0;
            end
        end
    end

    // PPS negedge
    reg     [2:0]   r_sync_ff;
    wire            w_pps_negedge = (r_sync_ff[2:1] == 2'b10);
    always @(posedge i_clk or negedge i_res_n) begin
        if (~i_res_n) begin
            r_sync_ff[2:0] <= 3'd0;
        end else begin
            r_sync_ff[2:0] <= {r_sync_ff[1:0], i_pps};
        end
    end


    always @(posedge i_clk or negedge i_res_n) begin
        if (~i_res_n) begin
            o_pps_sync_en <= 1'b0;
        end else begin
            if (r_sc_gate) begin
                o_pps_sync_en <= 1'b1;
            end else if (w_pps_negedge) begin
                o_pps_sync_en <= 1'b0;
            end
        end
    end

endmodule
