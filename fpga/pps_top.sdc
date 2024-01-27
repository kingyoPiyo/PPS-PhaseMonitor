## Generated SDC file "pps_top.sdc"

## Copyright (C) 2021  Intel Corporation. All rights reserved.
## Your use of Intel Corporation's design tools, logic functions 
## and other software and tools, and any partner logic 
## functions, and any output files from any of the foregoing 
## (including device programming or simulation files), and any 
## associated documentation or information are expressly subject 
## to the terms and conditions of the Intel Program License 
## Subscription Agreement, the Intel Quartus Prime License Agreement,
## the Intel FPGA IP License Agreement, or other applicable license
## agreement, including, without limitation, that your use is for
## the sole purpose of programming logic devices manufactured by
## Intel and sold by Intel or its authorized distributors.  Please
## refer to the applicable agreement for further details, at
## https://fpgasoftware.intel.com/eula.


## VENDOR  "Altera"
## PROGRAM "Quartus Prime"
## VERSION "Version 21.1.0 Build 842 10/21/2021 SJ Lite Edition"

## DATE    "Sat Jan 13 02:19:28 2024"

##
## DEVICE  "10M50DAF484C6GES"
##


#**************************************************************
# Time Information
#**************************************************************

set_time_format -unit ns -decimal_places 3



#**************************************************************
# Create Clock
#**************************************************************

create_clock -name {MCO} -period 20.000 -waveform { 0.000 10.000 } [get_ports {MCO}]
create_clock -name {REF_CLK} -period 200.000 -waveform { 0.000 100.000 } [get_ports {REF_CLK}]


#**************************************************************
# Create Generated Clock
#**************************************************************

create_generated_clock -name {w_clk50m} -source [get_pins {pll_inst|altpll_component|auto_generated|pll1|inclk[0]}] -duty_cycle 50/1 -multiply_by 1 -master_clock {MCO} [get_pins {pll_inst|altpll_component|auto_generated|pll1|clk[2]}] 
create_generated_clock -name {w_clk250m} -source [get_pins {pll_inst|altpll_component|auto_generated|pll1|inclk[0]}] -duty_cycle 50/1 -multiply_by 5 -master_clock {MCO} [get_pins {pll_inst|altpll_component|auto_generated|pll1|clk[1]}] 
create_generated_clock -name {w_clk500m} -source [get_pins {pll_inst|altpll_component|auto_generated|pll1|inclk[0]}] -duty_cycle 50/1 -multiply_by 10 -master_clock {MCO} [get_pins {pll_inst|altpll_component|auto_generated|pll1|clk[0]}] 

create_generated_clock -name {w_ref100m} -source [get_pins {pll_ref_inst|altpll_component|auto_generated|pll1|inclk[0]}] -duty_cycle 50/1 -multiply_by 20 -master_clock {REF_CLK} [get_pins {pll_ref_inst|altpll_component|auto_generated|pll1|clk[1]}] 


#**************************************************************
# Set Clock Latency
#**************************************************************



#**************************************************************
# Set Clock Uncertainty
#**************************************************************

set_clock_uncertainty -rise_from [get_clocks {w_clk50m}] -rise_to [get_clocks {w_clk50m}]  0.020  
set_clock_uncertainty -rise_from [get_clocks {w_clk50m}] -fall_to [get_clocks {w_clk50m}]  0.020  
set_clock_uncertainty -rise_from [get_clocks {w_clk50m}] -rise_to [get_clocks {w_clk250m}]  0.020  
set_clock_uncertainty -rise_from [get_clocks {w_clk50m}] -fall_to [get_clocks {w_clk250m}]  0.020  
set_clock_uncertainty -fall_from [get_clocks {w_clk50m}] -rise_to [get_clocks {w_clk50m}]  0.020  
set_clock_uncertainty -fall_from [get_clocks {w_clk50m}] -fall_to [get_clocks {w_clk50m}]  0.020  
set_clock_uncertainty -fall_from [get_clocks {w_clk50m}] -rise_to [get_clocks {w_clk250m}]  0.020  
set_clock_uncertainty -fall_from [get_clocks {w_clk50m}] -fall_to [get_clocks {w_clk250m}]  0.020  
set_clock_uncertainty -rise_from [get_clocks {w_clk250m}] -rise_to [get_clocks {w_clk250m}]  0.020  
set_clock_uncertainty -rise_from [get_clocks {w_clk250m}] -fall_to [get_clocks {w_clk250m}]  0.020  
set_clock_uncertainty -fall_from [get_clocks {w_clk250m}] -rise_to [get_clocks {w_clk250m}]  0.020  
set_clock_uncertainty -fall_from [get_clocks {w_clk250m}] -fall_to [get_clocks {w_clk250m}]  0.020  
set_clock_uncertainty -rise_from [get_clocks {w_clk500m}] -rise_to [get_clocks {w_clk250m}]  0.020  
set_clock_uncertainty -rise_from [get_clocks {w_clk500m}] -fall_to [get_clocks {w_clk250m}]  0.020  
set_clock_uncertainty -rise_from [get_clocks {w_clk500m}] -rise_to [get_clocks {w_clk500m}]  0.020  
set_clock_uncertainty -rise_from [get_clocks {w_clk500m}] -fall_to [get_clocks {w_clk500m}]  0.020  
set_clock_uncertainty -fall_from [get_clocks {w_clk500m}] -rise_to [get_clocks {w_clk250m}]  0.020  
set_clock_uncertainty -fall_from [get_clocks {w_clk500m}] -fall_to [get_clocks {w_clk250m}]  0.020  
set_clock_uncertainty -fall_from [get_clocks {w_clk500m}] -rise_to [get_clocks {w_clk500m}]  0.020  
set_clock_uncertainty -fall_from [get_clocks {w_clk500m}] -fall_to [get_clocks {w_clk500m}]  0.020  
set_clock_uncertainty -rise_from [get_clocks {w_ref100m}] -rise_to [get_clocks {w_clk500m}]  0.150  
set_clock_uncertainty -rise_from [get_clocks {w_ref100m}] -fall_to [get_clocks {w_clk500m}]  0.150  
set_clock_uncertainty -rise_from [get_clocks {w_ref100m}] -rise_to [get_clocks {w_ref100m}]  0.020  
set_clock_uncertainty -rise_from [get_clocks {w_ref100m}] -fall_to [get_clocks {w_ref100m}]  0.020  
set_clock_uncertainty -fall_from [get_clocks {w_ref100m}] -rise_to [get_clocks {w_clk500m}]  0.150  
set_clock_uncertainty -fall_from [get_clocks {w_ref100m}] -fall_to [get_clocks {w_clk500m}]  0.150  
set_clock_uncertainty -fall_from [get_clocks {w_ref100m}] -rise_to [get_clocks {w_ref100m}]  0.020  
set_clock_uncertainty -fall_from [get_clocks {w_ref100m}] -fall_to [get_clocks {w_ref100m}]  0.020  
 


#**************************************************************
# Set Input Delay
#**************************************************************



#**************************************************************
# Set Output Delay
#**************************************************************



#**************************************************************
# Set Clock Groups
#**************************************************************


#**************************************************************
# Set False Path
#**************************************************************

set_false_path -from [get_ports {RST_N}]
set_false_path -from [get_ports {USER_PB[*]}]
set_false_path -from [get_ports {USER_DIPSW[*]}]
set_false_path -from [get_ports {REF_CLK}]
set_false_path -from [get_ports {PPS1}]
set_false_path -from [get_ports {PPS2}]
set_false_path -from [get_ports {PPS3}]
set_false_path -from [get_ports {PPS4}]
set_false_path -to [get_ports {PPSO1}]
set_false_path -to [get_ports {UART_TX}]
set_false_path -from [get_ports {UART_RX}]
set_false_path -to [get_ports {PANEL_LED[*]}]
set_false_path -to [get_ports {ONB_LED[*]}]
set_false_path -to [get_ports {PANEL_ERR}]
set_false_path -to [get_ports {PANEL_PPS}]
set_false_path -to [get_ports {SFP_TXD}]

# w_clk250m -> w_clk50m
# phase_meas.v
set_false_path -from [get_clocks {w_clk250m}] -to [get_clocks {w_clk50m}]

# w_ref100m -> w_clk50m
# freq_counter.v
set_false_path -from [get_clocks {w_ref100m}] -to [get_clocks {w_clk50m}]

#**************************************************************
# Set Multicycle Path
#**************************************************************



#**************************************************************
# Set Maximum Delay
#**************************************************************



#**************************************************************
# Set Minimum Delay
#**************************************************************



#**************************************************************
# Set Input Transition
#**************************************************************

