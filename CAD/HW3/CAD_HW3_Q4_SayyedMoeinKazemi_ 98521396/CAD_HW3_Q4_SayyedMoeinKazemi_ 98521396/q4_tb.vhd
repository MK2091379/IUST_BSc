library ieee;
use ieee.std_logic_1164.all; 
use ieee.numeric_std.all;

entity q4_tb is
end q4_tb;

architecture q4_tb of q4_tb is
signal unary : std_logic_vector(15 downto 0) := "0000000000000000";
signal binary : std_logic_vector(3 downto 0) := "0000";
begin
	device : entity work.q4
	port map (
	unary => unary,
	binary => binary
	);
	process
	begin
		unary <= "0000000111111111";
		wait for 10 ns;
		
		unary <= "0000111111111111";
		wait for 10 ns;
	end process;
end q4_tb;
