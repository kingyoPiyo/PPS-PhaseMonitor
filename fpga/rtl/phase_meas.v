module phase_meas (
    input   wire            i_res_n,
    input   wire            i_clk,      // 400MHz
    input   wire            i_clk2,     // 50MHz
    input   wire            i_pps1,
    input   wire            i_pps2,
    input   wire            i_pps3,
    input   wire            i_pps4,

    // 位相結果(50MHzドメイン)
    output  reg             o_ph_en,
    output  reg     [28:0]  o_ph1,
    output  reg     [28:0]  o_ph2,
    output  reg     [28:0]  o_ph3,
    output  reg     [28:0]  o_ph4
    );


    // Phase counter
    reg     [28:0]  r_cnt;
    always @(posedge i_clk or negedge i_res_n) begin
        if (~i_res_n) begin
            r_cnt[28:0] <= 29'd0;
        end else begin
            r_cnt[28:0] <= r_cnt[28:0] + 29'd1;
        end
    end

    // Input signal sync
    reg     [2:0]   r_sync_pps1;
    reg     [2:0]   r_sync_pps2;
    reg     [2:0]   r_sync_pps3;
    reg     [2:0]   r_sync_pps4;
    always @(posedge i_clk or negedge i_res_n) begin
        if (~i_res_n) begin
            r_sync_pps1[2:0] <= 3'b000;
            r_sync_pps2[2:0] <= 3'b000;
            r_sync_pps3[2:0] <= 3'b000;
            r_sync_pps4[2:0] <= 3'b000;
        end else begin
            r_sync_pps1[2:0] <= {r_sync_pps1[1:0], i_pps1};
            r_sync_pps2[2:0] <= {r_sync_pps2[1:0], i_pps2};
            r_sync_pps3[2:0] <= {r_sync_pps3[1:0], i_pps3};
            r_sync_pps4[2:0] <= {r_sync_pps4[1:0], i_pps4};
        end    
    end

    // Capture triger (posedge)
    reg             r_captrig_1;
    reg             r_captrig_2;
    reg             r_captrig_3;
    reg             r_captrig_4;
    always @(posedge i_clk or negedge i_res_n) begin
        if (~i_res_n) begin
            r_captrig_1 <= 1'b0;
            r_captrig_2 <= 1'b0;
            r_captrig_3 <= 1'b0;
            r_captrig_4 <= 1'b0;
        end else begin
            r_captrig_1 <= (r_sync_pps1[2:1] == 2'b01) ? 1'b1 : 1'b0;
            r_captrig_2 <= (r_sync_pps2[2:1] == 2'b01) ? 1'b1 : 1'b0;
            r_captrig_3 <= (r_sync_pps3[2:1] == 2'b01) ? 1'b1 : 1'b0;
            r_captrig_4 <= (r_sync_pps4[2:1] == 2'b01) ? 1'b1 : 1'b0;
        end
    end

    // Posedge capture
    reg     [28:0]  r_cap1;
    reg     [28:0]  r_cap2;
    reg     [28:0]  r_cap3;
    reg     [28:0]  r_cap4;
    always @(posedge i_clk or negedge i_res_n) begin
        if (~i_res_n) begin
            r_cap1[28:0] <= 29'd0;
            r_cap2[28:0] <= 29'd0;
            r_cap3[28:0] <= 29'd0;
            r_cap4[28:0] <= 29'd0;
        end else begin
            if (r_captrig_1) r_cap1[28:0] <= r_cnt[28:0];
            if (r_captrig_2) r_cap2[28:0] <= r_cnt[28:0];
            if (r_captrig_3) r_cap3[28:0] <= r_cnt[28:0];
            if (r_captrig_4) r_cap4[28:0] <= r_cnt[28:0];
        end
    end



    //////////////////////////////////////////////////////////
    // 400MHz -> 50MHz 載せ替え
    // r_cap* -> o_ph*
    // PPS1~4の位相差が十分小さいことを前提に、
    // PPS1の立ち上がりエッジから遅延させて結果を取り込む
    //////////////////////////////////////////////////////////

    // PPS1立ち上がりエッジ検出
    reg     [2:0]   r_pps1_ff_50m;
    wire            w_pps1_posedge_50m = (r_pps1_ff_50m[2:1] == 2'b01);    
    always @(posedge i_clk2 or negedge i_res_n) begin
        if (~i_res_n) begin
            r_pps1_ff_50m[2:0] <= 3'd0;
        end else begin
            r_pps1_ff_50m[2:0] <= {r_pps1_ff_50m[1:0], i_pps1};
        end
    end

    // ディレイ追加
    reg     [25:0]  r_dly_cnt_50m;
    reg             r_dly_st_50m;
    always @(posedge i_clk2 or negedge i_res_n) begin
        if (~i_res_n) begin
            r_dly_cnt_50m[25:0] <= 26'h3FFFFFF;
            r_dly_st_50m <= 1'b0;
        end else if (w_pps1_posedge_50m) begin
            r_dly_cnt_50m[25:0] <= 26'h0;
            r_dly_st_50m <= 1'b0;
        end else if (r_dly_cnt_50m[25:0] != 26'h3FFFFFF) begin
            r_dly_cnt_50m[25:0] <= r_dly_cnt_50m[25:0] + 26'd1;
            r_dly_st_50m <= (r_dly_cnt_50m[25:0] == 26'd50000);     // 遅延量を設定
        end
    end

    // 載せ替え
    always @(posedge i_clk2 or negedge i_res_n) begin
        if (~i_res_n) begin
            o_ph_en <= 1'b0;
            o_ph1[28:0] <= 29'd0;
            o_ph2[28:0] <= 29'd0;
            o_ph3[28:0] <= 29'd0;
            o_ph4[28:0] <= 29'd0;
        end else if (r_dly_st_50m) begin
            o_ph_en <= 1'b1;
            o_ph1[28:0] <= r_cap1[28:0];
            o_ph2[28:0] <= r_cap2[28:0];
            o_ph3[28:0] <= r_cap3[28:0];
            o_ph4[28:0] <= r_cap4[28:0];
        end else begin
            o_ph_en <= 1'b0;
        end
    end

endmodule