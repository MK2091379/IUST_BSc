library ieee;
use ieee.std_logic_1164.all; 
use ieee.numeric_std.all;

entity q3_tb is
end q3_tb;

architecture q3_tb of q3_tb is
signal binary : std_logic_vector(7 downto 0) := "10110011";	-- 179
signal bcd : std_logic_vector(0 to 11) := "000000000000";
begin
	device : entity work.q3
	port map (
	binary => binary,
	bcd => bcd
	);
end q3_tb;
