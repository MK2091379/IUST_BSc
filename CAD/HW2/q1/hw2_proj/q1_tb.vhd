
LIBRARY ieee;
USE ieee.std_logic_1164.ALL;
 
-- Uncomment the following library declaration if using
-- arithmetic functions with Signed or Unsigned values
--USE ieee.numeric_std.ALL;
 
ENTITY q1_tb IS
END q1_tb;
 
ARCHITECTURE behavior OF q1_tb IS 
 
    -- Component Declaration for the Unit Under Test (UUT)
 
    COMPONENT q1
    PORT(
         x : IN  std_logic;
         y : IN  std_logic;
         z : OUT  std_logic
        );
    END COMPONENT;
    

   --Inputs
   signal x : std_logic := '0';
   signal y : std_logic := '0';

 	--Outputs
   signal z : std_logic;
   -- No clocks detected in port list. Replace <clock> below with 
   -- appropriate port name 
 
BEGIN
 
	-- Instantiate the Unit Under Test (UUT)
   uut: q1 PORT MAP (
          x => x,
          y => y,
          z => z
        );

   -- Stimulus process
   stim_proc: process
   begin		
      -- hold reset state for 100 ns.
		
		x <= '1';
		y <= '0';
		wait for 100 ns;
		x <= '0';      
      wait for 100 ns;
		y <= '1';
      wait for 100 ns;	
		x <= '1';
		wait for 100 ns;
		y <= '0';

      -- insert stimulus here 

      wait;
   end process;

END;
