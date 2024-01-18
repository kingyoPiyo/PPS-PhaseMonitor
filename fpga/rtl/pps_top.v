module pps_top (
    input   wire            MCO,        // Onboard 50MHz
    input   wire            RST_N,      // Onboard RST SW
    input   wire    [3:0]   USER_PB,    // Low Active
    input   wire    [5:0]   USER_DIPSW, // ON = Low
    input   wire            REF_CLK,    // REF 5MHz

    // PPS Input
    input   wire            PPS1,       // PMODB_D0(J9-1)
    input   wire            PPS2,       // PMODB_D1(J9-2)
    input   wire            PPS3,       // PMODB_D2(J9-3)
    input   wire            PPS4,       // PMODB_D3(J9-4)

    // PPS Output
    output  wire            PPSO1,      // PMODA_D0(J8-1)

    // UART
    output  wire            UART_TX,
    input   wire            UART_RX,

    // LED
    output  wire    [3:0]   PANEL_LED,  // High Active
    output  wire    [4:0]   ONB_LED     // Low Active
    );


    // Wire
    wire    w_clk400m;
    wire    w_clk100m;
    wire    w_clk50m;
    wire    w_pll_locked;
    wire    w_ref10m;
    wire    w_ref100m;
    wire    w_refpll_locked;
    wire    w_ph_en;
    (* syn_keep=1 *) wire    [28:0]  w_ph1;
    (* syn_keep=1 *) wire    [28:0]  w_ph2;
    (* syn_keep=1 *) wire    [28:0]  w_ph3;
    (* syn_keep=1 *) wire    [28:0]  w_ph4;


    // Clock generator from Onboard OSC
    pll	pll_inst (
        .areset ( ~RST_N ),
        .inclk0 ( MCO ),        // 50MHz
        .c0 ( w_clk400m ),      // 400MHz
        .c1 ( w_clk100m ),      // 100MHz
        .c2 ( w_clk50m ),       // 50MHz
        .locked ( w_pll_locked )
	);


    // Clock generator from External Ref-clock
    pll_ref	pll_ref_inst (
        .areset ( ~RST_N ),
        .inclk0 ( REF_CLK ),
        .c0 ( w_ref10m ),       // 10MHz
        .c1 ( w_ref100m ),      // 100MHz
        .locked ( w_refpll_locked )
	);


    // Phase measurement
    phase_meas phase_meas_inst (
        .i_res_n ( RST_N ),
        .i_clk ( w_clk400m ),
        .i_clk2 ( w_clk50m ),
        .i_pps1 ( PPS1 ),
        .i_pps2 ( PPS2 ),
        .i_pps3 ( PPS3 ),
        .i_pps4 ( PPS4 ),
        .o_ph_en ( w_ph_en ),   // ** 50MHz **
        .o_ph1 ( w_ph1[28:0] ), // ** 50MHz **
        .o_ph2 ( w_ph2[28:0] ), // ** 50MHz **
        .o_ph3 ( w_ph3[28:0] ), // ** 50MHz **
        .o_ph4 ( w_ph4[28:0] )  // ** 50MHz **
    );


    // UART TX
    ans_proc ans_proc_inst (
        .i_clk ( w_clk50m ),
        .i_rst_n ( RST_N ),
        .i_ph1 ( w_ph1[28:0] ),
        .i_ph2 ( w_ph2[28:0] ),
        .i_ph3 ( w_ph3[28:0] ),
        .i_ph4 ( w_ph4[28:0] ),
        .i_tx_start ( w_ph_en ),
        .o_uart_tx ( UART_TX )
    );


    // 1PPS signal generator
    pps_gen pps_gen_inst (
        .i_clk ( w_ref100m ),
        .i_res_n ( RST_N ),
        .i_ph_sync ( PPS1 & ~USER_PB[0] ),
        .o_pps ( PPSO1 )
    );


    // LED
    assign ONB_LED[0] = ~PPS1;
    assign ONB_LED[1] = ~PPS2;
    assign ONB_LED[2] = ~PPS3;
    assign ONB_LED[3] = ~PPS4;
    assign ONB_LED[4] = ~w_refpll_locked;
    assign PANEL_LED[0] = PPS1;
    assign PANEL_LED[1] = PPS2;
    assign PANEL_LED[2] = PPS3;
    //assign PANEL_LED[3] = PPS4;
    assign PANEL_LED[3] = PPSO1;

endmodule
