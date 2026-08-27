----------------------------------------------------------------------------------
-- Company: 
-- Engineer: 
-- 
-- Create Date:    21:42:04 11/24/2022 
-- Design Name: 
-- Module Name:    stack_q4 - Behavioral 
-- Project Name: 
-- Target Devices: 
-- Tool versions: 
-- Description: 
--
-- Dependencies: 
--
-- Revision: 
-- Revision 0.01 - File Created
-- Additional Comments: 
--
----------------------------------------------------------------------------------
library IEEE;
use IEEE.STD_LOGIC_1164.ALL;

-- Uncomment the following library declaration if using
-- arithmetic functions with Signed or Unsigned values
--use IEEE.NUMERIC_STD.ALL;

-- Uncomment the following library declaration if instantiating
-- any Xilinx primitives in this code.
--library UNISIM;
--use UNISIM.VComponents.all;

entity stack_q4 is
    Port ( datain : in  std_logic_vector(7 downto 0);
           dataout : out  std_logic_vector(7 downto 0);
           pushOrPop : in  STD_LOGIC;
           stack_full : out  STD_LOGIC;
           stack_empty : out  STD_LOGIC);
end stack_q4;

architecture Behavioral of stack_q4 is
 type mem_type is array (0 to 15) of std_logic_vector(7 downto 0);
	signal stack_mem : mem_type := (others => (others => '0'));
	signal full,empty : std_logic := '0';
	signal prev_PP : std_logic := '0';
	 signal SP : integer := 0;  --for simulation and debugging. 
begin
	process(datain,pushOrPop)
	 variable stack_ptr : integer := 15;
	begin
	Stack_Full <= full; 
	Stack_Empty <= empty;


   prev_PP <=pushOrPop; 
	
	if (pushOrPop = '0' and empty = '0') then
		 if(stack_ptr = 255) then
			full <= '0';
			empty <= '1';
		 else
			full <= '0';
			empty <= '0';
		end if;
                if(prev_PP = '1' and full = '0') then
                    stack_ptr := stack_ptr + 1;
                end if; 
                dataout <= stack_mem(stack_ptr);
            if(stack_ptr /= 255) then   
                stack_ptr := stack_ptr + 1;
            end if;   
	end if;
	       if (pushOrPop= '1' and full = '0') then
                if(stack_ptr = 0) then
                     full <= '1';
                     empty <= '0';
                else
                     full <= '0';
                     empty <= '0';
                end if; 
                if(prev_PP = '0' and empty = '0') then
                    stack_ptr := stack_ptr - 1;
                end if;
                stack_mem(stack_ptr) <= datain; 
            if(stack_ptr /= 0) then
                stack_ptr := stack_ptr - 1;
            end if;     
        end if;
	           SP <= stack_ptr;  --for debugging/simulation.
	end process;
end Behavioral;

