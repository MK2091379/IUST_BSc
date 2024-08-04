--------------------------------------------------------------------------------
-- Company: 
-- Engineer:
--
-- Create Date:   01:05:23 12/26/2022
-- Design Name:   
-- Module Name:   C:/Users/ASUS/Desktop/hw2/hw2_proj/q3_tb.vhd
-- Project Name:  hw2_proj
-- Target Device:  
-- Tool versions:  
-- Description:   
-- 
-- VHDL Test Bench Created by ISE for module: q3
-- 
-- Dependencies:
-- 
-- Revision:
-- Revision 0.01 - File Created
-- Additional Comments:
--
-- Notes: 
-- This testbench has been automatically generated using types std_logic and
-- std_logic_vector for the ports of the unit under test.  Xilinx recommends
-- that these types always be used for the top-level I/O of a design in order
-- to guarantee that the testbench will bind correctly to the post-implementation 
-- simulation model.
--------------------------------------------------------------------------------
LIBRARY ieee;
USE ieee.std_logic_1164.ALL;
 
-- Uncomment the following library declaration if using
-- arithmetic functions with Signed or Unsigned values
--USE ieee.numeric_std.ALL;
 
ENTITY q3_tb IS
END q3_tb;
 
ARCHITECTURE behavior OF q3_tb IS 
 
    -- Component Declaration for the Unit Under Test (UUT)
 
    COMPONENT q3
    PORT(
         addr : IN  std_logic_vector(31 downto 0);
         data : OUT  std_logic_vector(31 downto 0);
         hit : OUT  std_logic
        );
    END COMPONENT;
    

   --Inputs
   signal addr : std_logic_vector(31 downto 0) := (others => '0');

 	--Outputs
   signal data : std_logic_vector(31 downto 0);
   signal hit : std_logic;
   -- No clocks detected in port list. Replace <clock> below with 
   -- appropriate port name 
 
BEGIN
 
	-- Instantiate the Unit Under Test (UUT)
   uut: q3 PORT MAP (
          addr => addr,
          data => data,
          hit => hit
        );


   -- Stimulus process
   stim_proc: process
   begin		
      -- hold reset state for 100 ns.
      wait for 100 ns;	

      -- insert stimulus here 

      wait;
   end process;

END;
