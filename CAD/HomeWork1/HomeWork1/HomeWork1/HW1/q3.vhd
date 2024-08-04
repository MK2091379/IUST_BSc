----------------------------------------------------------------------------------
-- Company: 
-- Engineer: 
-- 
-- Create Date:    20:18:38 11/24/2022 
-- Design Name: 
-- Module Name:    q3 - Behavioral 
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
use IEEE.STD_LOGIC_UNSIGNED.ALL;

-- Uncomment the following library declaration if using
-- arithmetic functions with Signed or Unsigned values
--use IEEE.NUMERIC_STD.ALL;

-- Uncomment the following library declaration if instantiating
-- any Xilinx primitives in this code.
--library UNISIM;
--use UNISIM.VComponents.all;

entity q3 is
	generic(
    constant binary5 : std_logic_vector(3 downto 0) := "0101"
	);
	
    Port ( input : in  STD_LOGIC_VECTOR(3 downto 0);
           reminder : out  STD_LOGIC_VECTOR(3 downto 0)
			);
end q3;

architecture Behavioral of q3 is
	signal temp : std_logic_vector(3 downto 0);
begin
    process(input)
	 variable temp_var: std_logic_vector(3 downto 0);
    begin
	 	 temp_var := input;

			if(temp_var < binary5) then
				temp_var := binary5 - temp_var;
			end if;
        while (temp_var >= binary5) loop
             if(temp_var >= binary5) then
                temp_var  := (temp_var - binary5);
            end if;
        end loop;
		  	temp <= temp_var;
		  end process;
	reminder <= temp;
end Behavioral;

