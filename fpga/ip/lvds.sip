set_global_assignment -entity "lvds" -library "lib_lvds" -name IP_TOOL_NAME "altera_soft_lvds"
set_global_assignment -entity "lvds" -library "lib_lvds" -name IP_TOOL_VERSION "21.1"
set_global_assignment -entity "lvds" -library "lib_lvds" -name IP_TOOL_ENV "mwpim"
set_global_assignment -library "lib_lvds" -name SPD_FILE [file join $::quartus(sip_path) "lvds.spd"]

set_global_assignment -library "lib_lvds" -name MISC_FILE [file join $::quartus(sip_path) "lvds_sim/lvds.v"]
set_global_assignment -library "lib_lvds" -name MISC_FILE [file join $::quartus(sip_path) "lvds_sim/altera_soft_lvds/altera_soft_lvds_rx_BWNr0.v"]
