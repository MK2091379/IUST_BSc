library ieee;
use ieee.std_logic_1164.all; 
use ieee.numeric_std.all;

entity q1_tb is
end q1_tb;


architecture q1_tb of q1_tb is
signal clk : std_logic := '1';
constant clockFrequency : integer := 200e6;
constant clockTime : time := 1000 ms / clockFrequency;
signal detected_count: integer := 0;
signal reset : std_logic := '0';
signal seq_in : std_logic := '0';
begin
	q1 : entity work.q1_entity
	port map (
	clk => clk,
	reset => reset,
	seq_in => seq_in,
	detected_count => detected_count
	);
	
	clk <= not clk after clockTime / 2;
	
	process (clk)
	variable seq_to_test : std_logic_vector(15 downto 0) := "1110100110101011";
	variable i : integer := 15;
	begin
		if (i >= 0 and clk'event and clk = '0') then
			seq_in <= seq_to_test(i);
			i:= i - 1;
			if ( i = -1 ) then
				reset <= '1';
			end if;
		end if;
	end process;
end q1_tb;
