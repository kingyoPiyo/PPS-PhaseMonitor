//altlvds_rx BUFFER_IMPLEMENTATION="RAM" CBX_DECLARE_ALL_CONNECTED_PORTS="OFF" CBX_SINGLE_OUTPUT_FILE="ON" COMMON_RX_TX_PLL="OFF" CYCLONEII_M4K_COMPATIBILITY="ON" DATA_ALIGN_ROLLOVER=4 DATA_RATE="720.0 Mbps" DESERIALIZATION_FACTOR=4 DEVICE_FAMILY="MAX 10" DPA_INITIAL_PHASE_VALUE=0 DPLL_LOCK_COUNT=0 DPLL_LOCK_WINDOW=0 ENABLE_DPA_ALIGN_TO_RISING_EDGE_ONLY="OFF" ENABLE_DPA_CALIBRATION="ON" ENABLE_DPA_INITIAL_PHASE_SELECTION="OFF" ENABLE_DPA_MODE="OFF" ENABLE_DPA_PLL_CALIBRATION="OFF" ENABLE_SOFT_CDR_MODE="OFF" IMPLEMENT_IN_LES="ON" INCLOCK_BOOST=0 INCLOCK_DATA_ALIGNMENT="EDGE_ALIGNED" INCLOCK_PERIOD=5000 INCLOCK_PHASE_SHIFT=0 INPUT_DATA_RATE=720 LVDS_RX_REG_SETTING="OFF" NUMBER_OF_CHANNELS=4 OUTCLOCK_RESOURCE="AUTO" PLL_SELF_RESET_ON_LOSS_LOCK="OFF" PORT_RX_CHANNEL_DATA_ALIGN="PORT_UNUSED" PORT_RX_DATA_ALIGN="PORT_USED" REGISTERED_DATA_ALIGN_INPUT="OFF" REGISTERED_OUTPUT="OFF" SIM_DPA_IS_NEGATIVE_PPM_DRIFT="OFF" SIM_DPA_NET_PPM_VARIATION=0 SIM_DPA_OUTPUT_CLOCK_PHASE_SHIFT=0 USE_CORECLOCK_INPUT="OFF" USE_DPLL_RAWPERROR="OFF" USE_EXTERNAL_PLL="ON" USE_NO_PHASE_SHIFT="ON" X_ON_BITSLIP="ON" rx_cda_reset rx_channel_data_align rx_data_align rx_data_align_reset rx_in rx_inclock rx_locked rx_out CARRY_CHAIN="MANUAL" CARRY_CHAIN_LENGTH=48 LOW_POWER_MODE="AUTO" ALTERA_INTERNAL_OPTIONS=AUTO_SHIFT_REGISTER_RECOGNITION=OFF
//VERSION_BEGIN 21.1 cbx_altaccumulate 2021:10:21:11:03:22:SJ cbx_altclkbuf 2021:10:21:11:03:22:SJ cbx_altddio_in 2021:10:21:11:03:22:SJ cbx_altddio_out 2021:10:21:11:03:22:SJ cbx_altera_syncram_nd_impl 2021:10:21:11:03:22:SJ cbx_altiobuf_bidir 2021:10:21:11:03:22:SJ cbx_altiobuf_in 2021:10:21:11:03:22:SJ cbx_altiobuf_out 2021:10:21:11:03:22:SJ cbx_altlvds_rx 2021:10:21:11:03:22:SJ cbx_altpll 2021:10:21:11:03:22:SJ cbx_altsyncram 2021:10:21:11:03:22:SJ cbx_arriav 2021:10:21:11:03:21:SJ cbx_cyclone 2021:10:21:11:03:22:SJ cbx_cycloneii 2021:10:21:11:03:22:SJ cbx_lpm_add_sub 2021:10:21:11:03:22:SJ cbx_lpm_compare 2021:10:21:11:03:21:SJ cbx_lpm_counter 2021:10:21:11:03:21:SJ cbx_lpm_decode 2021:10:21:11:03:21:SJ cbx_lpm_mux 2021:10:21:11:03:22:SJ cbx_lpm_shiftreg 2021:10:21:11:03:22:SJ cbx_maxii 2021:10:21:11:03:22:SJ cbx_mgl 2021:10:21:11:03:46:SJ cbx_nadder 2021:10:21:11:03:22:SJ cbx_stratix 2021:10:21:11:03:22:SJ cbx_stratixii 2021:10:21:11:03:22:SJ cbx_stratixiii 2021:10:21:11:03:22:SJ cbx_stratixv 2021:10:21:11:03:22:SJ cbx_util_mgl 2021:10:21:11:03:22:SJ  VERSION_END
// synthesis VERILOG_INPUT_VERSION VERILOG_2001
// altera message_off 10463



// Copyright (C) 2021  Intel Corporation. All rights reserved.
//  Your use of Intel Corporation's design tools, logic functions 
//  and other software and tools, and any partner logic 
//  functions, and any output files from any of the foregoing 
//  (including device programming or simulation files), and any 
//  associated documentation or information are expressly subject 
//  to the terms and conditions of the Intel Program License 
//  Subscription Agreement, the Intel Quartus Prime License Agreement,
//  the Intel FPGA IP License Agreement, or other applicable license
//  agreement, including, without limitation, that your use is for
//  the sole purpose of programming logic devices manufactured by
//  Intel and sold by Intel or its authorized distributors.  Please
//  refer to the applicable agreement for further details, at
//  https://fpgasoftware.intel.com/eula.




//alt_lvds_ddio_in ADD_LATENCY_REG="TRUE" CBX_DECLARE_ALL_CONNECTED_PORTS="OFF" CBX_SINGLE_OUTPUT_FILE="ON" LVDS_RX_REG_SETTING="OFF" WIDTH=4 clock datain dataout_h dataout_l
//VERSION_BEGIN 21.1 cbx_altaccumulate 2021:10:21:11:03:22:SJ cbx_altclkbuf 2021:10:21:11:03:22:SJ cbx_altddio_in 2021:10:21:11:03:22:SJ cbx_altddio_out 2021:10:21:11:03:22:SJ cbx_altera_syncram_nd_impl 2021:10:21:11:03:22:SJ cbx_altiobuf_bidir 2021:10:21:11:03:22:SJ cbx_altiobuf_in 2021:10:21:11:03:22:SJ cbx_altiobuf_out 2021:10:21:11:03:22:SJ cbx_altlvds_rx 2021:10:21:11:03:22:SJ cbx_altpll 2021:10:21:11:03:22:SJ cbx_altsyncram 2021:10:21:11:03:22:SJ cbx_arriav 2021:10:21:11:03:21:SJ cbx_cyclone 2021:10:21:11:03:22:SJ cbx_cycloneii 2021:10:21:11:03:22:SJ cbx_lpm_add_sub 2021:10:21:11:03:22:SJ cbx_lpm_compare 2021:10:21:11:03:21:SJ cbx_lpm_counter 2021:10:21:11:03:21:SJ cbx_lpm_decode 2021:10:21:11:03:21:SJ cbx_lpm_mux 2021:10:21:11:03:22:SJ cbx_lpm_shiftreg 2021:10:21:11:03:22:SJ cbx_maxii 2021:10:21:11:03:22:SJ cbx_mgl 2021:10:21:11:03:46:SJ cbx_nadder 2021:10:21:11:03:22:SJ cbx_stratix 2021:10:21:11:03:22:SJ cbx_stratixii 2021:10:21:11:03:22:SJ cbx_stratixiii 2021:10:21:11:03:22:SJ cbx_stratixv 2021:10:21:11:03:22:SJ cbx_util_mgl 2021:10:21:11:03:22:SJ  VERSION_END

//synthesis_resources = reg 20 
//synopsys translate_off
`timescale 1 ps / 1 ps
//synopsys translate_on
(* ALTERA_ATTRIBUTE = {"{-to ddio_h_reg*} PLL_COMPENSATE=ON;ADV_NETLIST_OPT_ALLOWED=\"NEVER_ALLOW\""} *)
module  altera_soft_lvds_rx_NW00c_lvds_ddio_in_k9g
	( 
	clock,
	datain,
	dataout_h,
	dataout_l) /* synthesis synthesis_clearbox=1 */;
	input   clock;
	input   [3:0]  datain;
	output   [3:0]  dataout_h;
	output   [3:0]  dataout_l;

	reg	[3:0]	dataout_h_reg;
	reg	[3:0]	dataout_l_latch;
	reg	[3:0]	dataout_l_reg;
	(* ALTERA_ATTRIBUTE = {"LVDS_RX_REGISTER=HIGH;PRESERVE_REGISTER=ON;PRESERVE_FANOUT_FREE_NODE=ON"} *)
	reg	[3:0]	ddio_h_reg;
	(* ALTERA_ATTRIBUTE = {"LVDS_RX_REGISTER=LOW;PRESERVE_REGISTER=ON;PRESERVE_FANOUT_FREE_NODE=ON"} *)
	reg	[3:0]	ddio_l_reg;

	// synopsys translate_off
	initial
		dataout_h_reg = 0;
	// synopsys translate_on
	always @ ( posedge clock)
		  dataout_h_reg <= ddio_h_reg;
	// synopsys translate_off
	initial
		dataout_l_latch = 0;
	// synopsys translate_on
	always @ ( negedge clock)
		  dataout_l_latch <= ddio_l_reg;
	// synopsys translate_off
	initial
		dataout_l_reg = 0;
	// synopsys translate_on
	always @ ( posedge clock)
		  dataout_l_reg <= dataout_l_latch;
	// synopsys translate_off
	initial
		ddio_h_reg = 0;
	// synopsys translate_on
	always @ ( posedge clock)
		  ddio_h_reg <= datain;
	// synopsys translate_off
	initial
		ddio_l_reg = 0;
	// synopsys translate_on
	always @ ( negedge clock)
		  ddio_l_reg <= datain;
	assign
		dataout_h = dataout_l_reg,
		dataout_l = dataout_h_reg;
endmodule //altera_soft_lvds_rx_NW00c_lvds_ddio_in_k9g


//dffpipe CBX_DECLARE_ALL_CONNECTED_PORTS="OFF" CBX_SINGLE_OUTPUT_FILE="ON" DELAY=1 WIDTH=4 clock d q ALTERA_INTERNAL_OPTIONS=AUTO_SHIFT_REGISTER_RECOGNITION=OFF
//VERSION_BEGIN 21.1 cbx_mgl 2021:10:21:11:03:46:SJ cbx_stratixii 2021:10:21:11:03:22:SJ cbx_util_mgl 2021:10:21:11:03:22:SJ  VERSION_END

//synthesis_resources = reg 4 
//synopsys translate_off
`timescale 1 ps / 1 ps
//synopsys translate_on
(* ALTERA_ATTRIBUTE = {"AUTO_SHIFT_REGISTER_RECOGNITION=OFF"} *)
module  altera_soft_lvds_rx_NW00c_dffpipe_g8f
	( 
	clock,
	d,
	q) /* synthesis synthesis_clearbox=1 */;
	input   clock;
	input   [3:0]  d;
	output   [3:0]  q;
`ifndef ALTERA_RESERVED_QIS
// synopsys translate_off
`endif
	tri0   clock;
`ifndef ALTERA_RESERVED_QIS
// synopsys translate_on
`endif

	reg	[3:0]	dffe25a;
	wire clrn;
	wire ena;
	wire prn;
	wire sclr;

	// synopsys translate_off
	initial
		dffe25a = 0;
	// synopsys translate_on
	always @ ( posedge clock or  negedge prn or  negedge clrn)
		if (prn == 1'b0) dffe25a <= {4{1'b1}};
		else if (clrn == 1'b0) dffe25a <= 4'b0;
		else if  (ena == 1'b1)   dffe25a <= (d & {4{(~ sclr)}});
	assign
		clrn = 1'b1,
		ena = 1'b1,
		prn = 1'b1,
		q = dffe25a,
		sclr = 1'b0;
endmodule //altera_soft_lvds_rx_NW00c_dffpipe_g8f


//lpm_counter CBX_DECLARE_ALL_CONNECTED_PORTS="OFF" CBX_SINGLE_OUTPUT_FILE="ON" DEVICE_FAMILY="MAX 10" lpm_modulus=4 lpm_port_updown="PORT_UNUSED" lpm_width=2 aclr clock cnt_en q
//VERSION_BEGIN 21.1 cbx_cycloneii 2021:10:21:11:03:22:SJ cbx_lpm_add_sub 2021:10:21:11:03:22:SJ cbx_lpm_compare 2021:10:21:11:03:21:SJ cbx_lpm_counter 2021:10:21:11:03:21:SJ cbx_lpm_decode 2021:10:21:11:03:21:SJ cbx_mgl 2021:10:21:11:03:46:SJ cbx_nadder 2021:10:21:11:03:22:SJ cbx_stratix 2021:10:21:11:03:22:SJ cbx_stratixii 2021:10:21:11:03:22:SJ  VERSION_END

//synthesis_resources = lut 2 reg 2 
//synopsys translate_off
`timescale 1 ps / 1 ps
//synopsys translate_on
module  altera_soft_lvds_rx_NW00c_cntr_6gg
	( 
	aclr,
	clock,
	cnt_en,
	q) /* synthesis synthesis_clearbox=1 */;
	input   aclr;
	input   clock;
	input   cnt_en;
	output   [1:0]  q;
`ifndef ALTERA_RESERVED_QIS
// synopsys translate_off
`endif
	tri0   aclr;
	tri1   cnt_en;
`ifndef ALTERA_RESERVED_QIS
// synopsys translate_on
`endif

	wire  [0:0]   wire_counter_comb_bita_0combout;
	wire  [0:0]   wire_counter_comb_bita_1combout;
	wire  [0:0]   wire_counter_comb_bita_0cout;
	wire	[1:0]	wire_counter_reg_bit_d;
	wire	[1:0]	wire_counter_reg_bit_asdata;
	reg	[1:0]	counter_reg_bit;
	wire	[1:0]	wire_counter_reg_bit_ena;
	wire	[1:0]	wire_counter_reg_bit_sload;
	wire  aclr_actual;
	wire clk_en;
	wire [1:0]  data;
	wire  external_cin;
	wire  [1:0]  s_val;
	wire  [1:0]  safe_q;
	wire sclr;
	wire sload;
	wire sset;
	wire  updown_dir;

	fiftyfivenm_lcell_comb   counter_comb_bita_0
	( 
	.cin(external_cin),
	.combout(wire_counter_comb_bita_0combout[0:0]),
	.cout(wire_counter_comb_bita_0cout[0:0]),
	.dataa(counter_reg_bit[0]),
	.datab(updown_dir),
	.datad(1'b1),
	.datac(1'b0)
	);
	defparam
		counter_comb_bita_0.lut_mask = 16'h5A90,
		counter_comb_bita_0.sum_lutc_input = "cin",
		counter_comb_bita_0.lpm_type = "fiftyfivenm_lcell_comb";
	fiftyfivenm_lcell_comb   counter_comb_bita_1
	( 
	.cin(wire_counter_comb_bita_0cout[0:0]),
	.combout(wire_counter_comb_bita_1combout[0:0]),
	.cout(),
	.dataa(counter_reg_bit[1]),
	.datab(updown_dir),
	.datad(1'b1),
	.datac(1'b0)
	);
	defparam
		counter_comb_bita_1.lut_mask = 16'h5A90,
		counter_comb_bita_1.sum_lutc_input = "cin",
		counter_comb_bita_1.lpm_type = "fiftyfivenm_lcell_comb";
	// synopsys translate_off
	initial
		counter_reg_bit[0:0] = 0;
	// synopsys translate_on
	always @ ( posedge clock or  posedge aclr_actual)
		if (aclr_actual == 1'b1) counter_reg_bit[0:0] <= 1'b0;
		else if  (wire_counter_reg_bit_ena[0:0] == 1'b1) 
			if (wire_counter_reg_bit_sload[0:0] == 1'b1) counter_reg_bit[0:0] <= wire_counter_reg_bit_asdata[0:0];
			else  counter_reg_bit[0:0] <= wire_counter_reg_bit_d[0:0];
	// synopsys translate_off
	initial
		counter_reg_bit[1:1] = 0;
	// synopsys translate_on
	always @ ( posedge clock or  posedge aclr_actual)
		if (aclr_actual == 1'b1) counter_reg_bit[1:1] <= 1'b0;
		else if  (wire_counter_reg_bit_ena[1:1] == 1'b1) 
			if (wire_counter_reg_bit_sload[1:1] == 1'b1) counter_reg_bit[1:1] <= wire_counter_reg_bit_asdata[1:1];
			else  counter_reg_bit[1:1] <= wire_counter_reg_bit_d[1:1];
	assign
		wire_counter_reg_bit_asdata = ({2{(~ sclr)}} & (({2{sset}} & s_val) | ({2{(~ sset)}} & data))),
		wire_counter_reg_bit_d = {wire_counter_comb_bita_1combout[0:0], wire_counter_comb_bita_0combout[0:0]};
	assign
		wire_counter_reg_bit_ena = {2{(clk_en & (((sclr | sset) | sload) | cnt_en))}},
		wire_counter_reg_bit_sload = {2{((sclr | sset) | sload)}};
	assign
		aclr_actual = aclr,
		clk_en = 1'b1,
		data = {2{1'b0}},
		external_cin = 1'b1,
		q = safe_q,
		s_val = {2{1'b1}},
		safe_q = counter_reg_bit,
		sclr = 1'b0,
		sload = 1'b0,
		sset = 1'b0,
		updown_dir = 1'b1;
endmodule //altera_soft_lvds_rx_NW00c_cntr_6gg


//lpm_mux CBX_DECLARE_ALL_CONNECTED_PORTS="OFF" CBX_SINGLE_OUTPUT_FILE="ON" DEVICE_FAMILY="MAX 10" LPM_SIZE=4 LPM_WIDTH=1 LPM_WIDTHS=2 data result sel
//VERSION_BEGIN 21.1 cbx_lpm_mux 2021:10:21:11:03:22:SJ cbx_mgl 2021:10:21:11:03:46:SJ  VERSION_END

//synthesis_resources = lut 2 
//synopsys translate_off
`timescale 1 ps / 1 ps
//synopsys translate_on
module  altera_soft_lvds_rx_NW00c_mux_0nd
	( 
	data,
	result,
	sel) /* synthesis synthesis_clearbox=1 */;
	input   [3:0]  data;
	output   [0:0]  result;
	input   [1:0]  sel;
`ifndef ALTERA_RESERVED_QIS
// synopsys translate_off
`endif
	tri0   [3:0]  data;
	tri0   [1:0]  sel;
`ifndef ALTERA_RESERVED_QIS
// synopsys translate_on
`endif

	wire  [0:0]  result_node;
	wire  [1:0]  sel_node;
	wire  [3:0]  w_data162w;

	assign
		result = result_node,
		result_node = {(((w_data162w[1] & sel_node[0]) & (~ (((w_data162w[0] & (~ sel_node[1])) & (~ sel_node[0])) | (sel_node[1] & (sel_node[0] | w_data162w[2]))))) | ((((w_data162w[0] & (~ sel_node[1])) & (~ sel_node[0])) | (sel_node[1] & (sel_node[0] | w_data162w[2]))) & (w_data162w[3] | (~ sel_node[0]))))},
		sel_node = {sel[1:0]},
		w_data162w = {data[3:0]};
endmodule //altera_soft_lvds_rx_NW00c_mux_0nd

//synthesis_resources = lut 18 reg 63 
//synopsys translate_off
`timescale 1 ps / 1 ps
//synopsys translate_on
(* ALTERA_ATTRIBUTE = {"AUTO_SHIFT_REGISTER_RECOGNITION=OFF"} *)
module  altera_soft_lvds_rx_NW00c
	( 
	rx_cda_reset,
	rx_channel_data_align,
	rx_data_align,
	rx_data_align_reset,
	rx_in,
	rx_inclock,
	rx_locked,
	rx_out) /* synthesis synthesis_clearbox=1 */;
	input   [3:0]  rx_cda_reset;
	input   [3:0]  rx_channel_data_align;
	input   rx_data_align;
	input   rx_data_align_reset;
	input   [3:0]  rx_in;
	input   rx_inclock;
	output   rx_locked;
	output   [15:0]  rx_out;
`ifndef ALTERA_RESERVED_QIS
// synopsys translate_off
`endif
	tri0   [3:0]  rx_cda_reset;
	tri0   [3:0]  rx_channel_data_align;
	tri0   rx_data_align;
	tri0   rx_data_align_reset;
`ifndef ALTERA_RESERVED_QIS
// synopsys translate_on
`endif

	wire  [3:0]   wire_ddio_in_dataout_h;
	wire  [3:0]   wire_ddio_in_dataout_l;
	reg	[0:0]	cda_h_shiftreg15a;
	reg	[0:0]	cda_h_shiftreg21a;
	reg	[0:0]	cda_h_shiftreg3a;
	reg	[0:0]	cda_h_shiftreg9a;
	reg	[1:0]	cda_l_shiftreg10a;
	reg	[1:0]	cda_l_shiftreg16a;
	reg	[1:0]	cda_l_shiftreg22a;
	reg	[1:0]	cda_l_shiftreg4a;
	reg	[1:0]	h_shiftreg14a;
	reg	[1:0]	h_shiftreg20a;
	reg	[1:0]	h_shiftreg2a;
	reg	[1:0]	h_shiftreg8a;
	reg	int_bitslip_reg;
	reg	int_da_reset_reg0;
	reg	int_da_reset_reg1;
	reg	int_sync_reg0;
	reg	int_sync_reg1;
	reg	[1:0]	l_shiftreg13a;
	reg	[1:0]	l_shiftreg19a;
	reg	[1:0]	l_shiftreg1a;
	reg	[1:0]	l_shiftreg7a;
	wire  [3:0]   wire_h_dffpipe_q;
	wire  [3:0]   wire_l_dffpipe_q;
	wire  [1:0]   wire_bitslip_cntr_q;
	wire  [0:0]   wire_h_mux11a_result;
	wire  [0:0]   wire_h_mux17a_result;
	wire  [0:0]   wire_h_mux23a_result;
	wire  [0:0]   wire_h_mux5a_result;
	wire  [0:0]   wire_l_mux12a_result;
	wire  [0:0]   wire_l_mux18a_result;
	wire  [0:0]   wire_l_mux24a_result;
	wire  [0:0]   wire_l_mux6a_result;
	wire  bitslip;
	wire  [1:0]  bitslip_en;
	wire  [3:0]  ddio_dataout_h;
	wire  [3:0]  ddio_dataout_h_int;
	wire  [3:0]  ddio_dataout_l;
	wire  [3:0]  ddio_dataout_l_int;
	wire  fast_clock;
	wire  int_bitslip;
	wire  [15:0]  rx_out_wire;

	altera_soft_lvds_rx_NW00c_lvds_ddio_in_k9g   ddio_in
	( 
	.clock(fast_clock),
	.datain(rx_in),
	.dataout_h(wire_ddio_in_dataout_h),
	.dataout_l(wire_ddio_in_dataout_l));
	// synopsys translate_off
	initial
		cda_h_shiftreg15a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  cda_h_shiftreg15a <= {ddio_dataout_h[2]};
	// synopsys translate_off
	initial
		cda_h_shiftreg21a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  cda_h_shiftreg21a <= {ddio_dataout_h[3]};
	// synopsys translate_off
	initial
		cda_h_shiftreg3a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  cda_h_shiftreg3a <= {ddio_dataout_h[0]};
	// synopsys translate_off
	initial
		cda_h_shiftreg9a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  cda_h_shiftreg9a <= {ddio_dataout_h[1]};
	// synopsys translate_off
	initial
		cda_l_shiftreg10a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  cda_l_shiftreg10a <= {cda_l_shiftreg10a[0], ddio_dataout_l[1]};
	// synopsys translate_off
	initial
		cda_l_shiftreg16a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  cda_l_shiftreg16a <= {cda_l_shiftreg16a[0], ddio_dataout_l[2]};
	// synopsys translate_off
	initial
		cda_l_shiftreg22a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  cda_l_shiftreg22a <= {cda_l_shiftreg22a[0], ddio_dataout_l[3]};
	// synopsys translate_off
	initial
		cda_l_shiftreg4a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  cda_l_shiftreg4a <= {cda_l_shiftreg4a[0], ddio_dataout_l[0]};
	// synopsys translate_off
	initial
		h_shiftreg14a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  h_shiftreg14a <= {h_shiftreg14a[0], wire_l_mux18a_result};
	// synopsys translate_off
	initial
		h_shiftreg20a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  h_shiftreg20a <= {h_shiftreg20a[0], wire_l_mux24a_result};
	// synopsys translate_off
	initial
		h_shiftreg2a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  h_shiftreg2a <= {h_shiftreg2a[0], wire_l_mux6a_result};
	// synopsys translate_off
	initial
		h_shiftreg8a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  h_shiftreg8a <= {h_shiftreg8a[0], wire_l_mux12a_result};
	// synopsys translate_off
	initial
		int_bitslip_reg = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  int_bitslip_reg <= int_bitslip;
	// synopsys translate_off
	initial
		int_da_reset_reg0 = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  int_da_reset_reg0 <= rx_data_align_reset;
	// synopsys translate_off
	initial
		int_da_reset_reg1 = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  int_da_reset_reg1 <= int_da_reset_reg0;
	// synopsys translate_off
	initial
		int_sync_reg0 = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  int_sync_reg0 <= rx_data_align;
	// synopsys translate_off
	initial
		int_sync_reg1 = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  int_sync_reg1 <= int_sync_reg0;
	// synopsys translate_off
	initial
		l_shiftreg13a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  l_shiftreg13a <= {l_shiftreg13a[0], wire_h_mux17a_result};
	// synopsys translate_off
	initial
		l_shiftreg19a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  l_shiftreg19a <= {l_shiftreg19a[0], wire_h_mux23a_result};
	// synopsys translate_off
	initial
		l_shiftreg1a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  l_shiftreg1a <= {l_shiftreg1a[0], wire_h_mux5a_result};
	// synopsys translate_off
	initial
		l_shiftreg7a = 0;
	// synopsys translate_on
	always @ ( posedge fast_clock)
		  l_shiftreg7a <= {l_shiftreg7a[0], wire_h_mux11a_result};
	altera_soft_lvds_rx_NW00c_dffpipe_g8f   h_dffpipe
	( 
	.clock(fast_clock),
	.d(ddio_dataout_h_int),
	.q(wire_h_dffpipe_q));
	altera_soft_lvds_rx_NW00c_dffpipe_g8f   l_dffpipe
	( 
	.clock(fast_clock),
	.d(ddio_dataout_l_int),
	.q(wire_l_dffpipe_q));
	altera_soft_lvds_rx_NW00c_cntr_6gg   bitslip_cntr
	( 
	.aclr(int_da_reset_reg1),
	.clock(fast_clock),
	.cnt_en(bitslip),
	.q(wire_bitslip_cntr_q));
	altera_soft_lvds_rx_NW00c_mux_0nd   h_mux11a
	( 
	.data({cda_l_shiftreg10a[1], cda_h_shiftreg9a[0], cda_l_shiftreg10a[0], ddio_dataout_h[1]}),
	.result(wire_h_mux11a_result),
	.sel(bitslip_en));
	altera_soft_lvds_rx_NW00c_mux_0nd   h_mux17a
	( 
	.data({cda_l_shiftreg16a[1], cda_h_shiftreg15a[0], cda_l_shiftreg16a[0], ddio_dataout_h[2]}),
	.result(wire_h_mux17a_result),
	.sel(bitslip_en));
	altera_soft_lvds_rx_NW00c_mux_0nd   h_mux23a
	( 
	.data({cda_l_shiftreg22a[1], cda_h_shiftreg21a[0], cda_l_shiftreg22a[0], ddio_dataout_h[3]}),
	.result(wire_h_mux23a_result),
	.sel(bitslip_en));
	altera_soft_lvds_rx_NW00c_mux_0nd   h_mux5a
	( 
	.data({cda_l_shiftreg4a[1], cda_h_shiftreg3a[0], cda_l_shiftreg4a[0], ddio_dataout_h[0]}),
	.result(wire_h_mux5a_result),
	.sel(bitslip_en));
	altera_soft_lvds_rx_NW00c_mux_0nd   l_mux12a
	( 
	.data({cda_h_shiftreg9a[0], cda_l_shiftreg10a[0], ddio_dataout_h[1], ddio_dataout_l[1]}),
	.result(wire_l_mux12a_result),
	.sel(bitslip_en));
	altera_soft_lvds_rx_NW00c_mux_0nd   l_mux18a
	( 
	.data({cda_h_shiftreg15a[0], cda_l_shiftreg16a[0], ddio_dataout_h[2], ddio_dataout_l[2]}),
	.result(wire_l_mux18a_result),
	.sel(bitslip_en));
	altera_soft_lvds_rx_NW00c_mux_0nd   l_mux24a
	( 
	.data({cda_h_shiftreg21a[0], cda_l_shiftreg22a[0], ddio_dataout_h[3], ddio_dataout_l[3]}),
	.result(wire_l_mux24a_result),
	.sel(bitslip_en));
	altera_soft_lvds_rx_NW00c_mux_0nd   l_mux6a
	( 
	.data({cda_h_shiftreg3a[0], cda_l_shiftreg4a[0], ddio_dataout_h[0], ddio_dataout_l[0]}),
	.result(wire_l_mux6a_result),
	.sel(bitslip_en));
	assign
		bitslip = ((~ int_bitslip_reg) & int_bitslip),
		bitslip_en = wire_bitslip_cntr_q,
		ddio_dataout_h = wire_h_dffpipe_q,
		ddio_dataout_h_int = wire_ddio_in_dataout_h,
		ddio_dataout_l = wire_l_dffpipe_q,
		ddio_dataout_l_int = wire_ddio_in_dataout_l,
		fast_clock = rx_inclock,
		int_bitslip = int_sync_reg1,
		rx_out = rx_out_wire,
		rx_out_wire = {l_shiftreg19a[1], h_shiftreg20a[1], l_shiftreg19a[0], h_shiftreg20a[0], l_shiftreg13a[1], h_shiftreg14a[1], l_shiftreg13a[0], h_shiftreg14a[0], l_shiftreg7a[1], h_shiftreg8a[1], l_shiftreg7a[0], h_shiftreg8a[0], l_shiftreg1a[1], h_shiftreg2a[1], l_shiftreg1a[0], h_shiftreg2a[0]};
endmodule //altera_soft_lvds_rx_NW00c
//VALID FILE
