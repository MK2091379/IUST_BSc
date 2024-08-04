--------------------------------------------------------------------------------
-- Company: 
-- Engineer:
--
-- Create Date:   00:18:12 12/26/2022
-- Design Name:   
-- Module Name:   C:/Users/ASUS/Desktop/hw2/hw2_proj/q2_tb.vhd
-- Project Name:  hw2_proj
-- Target Device:  
-- Tool versions:  
-- Description:   
-- 
-- VHDL Test Bench Created by ISE for module: q2
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
USE ieee.numeric_std.ALL;
 
ENTITY q2_tb IS
END q2_tb;
 
ARCHITECTURE behavior OF q2_tb IS 
 
    -- Component Declaration for the Unit Under Test (UUT)
 
    COMPONENT q2
    PORT(
         op1 : IN  std_logic_vector(31 downto 0);
         op2 : IN  std_logic_vector(31 downto 0);
         mul : OUT  std_logic_vector(31 downto 0)
        );
    END COMPONENT;
    

   --Inputs
   signal op1 : std_logic_vector(31 downto 0) := (others => '0');
   signal op2 : std_logic_vector(31 downto 0) := (others => '0');

 	--Outputs
   signal mul : std_logic_vector(31 downto 0);
   -- No clocks detected in port list. Replace <clock> below with 
   -- appropriate port name 
 
 
BEGIN
 
	-- Instantiate the Unit Under Test (UUT)
   uut: q2 PORT MAP (
          op1 => op1,
          op2 => op2,
          mul => mul
        );
 

   -- Stimulus process
   stim_proc: process
   begin		
      -- hold reset state for 100 ns.
      wait for 100 ns;	

      op1 <= "00001100010010010000111010111110";
		op2 <= "01000011100000101010101001111001";
      wait for 100 ns;	

		op1 <= "00001100010010010001110011011011";
		op2 <= "10001111010010010000111110000001";
      wait for 100 ns;

      wait;
   end process;

END;
