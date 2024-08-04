library ieee;
use ieee.std_logic_1164.all; 
use ieee.numeric_std.all;

entity q1_entity is
	port(
		clk: in std_logic;
		reset: in std_logic;
		seq_in: in std_logic;
		detected_count: out integer
	);
end q1_entity;

architecture behavioural of q1_entity is
type state is (q0,q1,q2,q3,q4);
signal current_state : state := q0;
signal next_state : state := q0;
signal sum : integer := 0;

begin
	process(clk, reset)
	begin
		if (rising_edge(clk)) then
			if (reset = '1') then
				current_state <= q0;
			else
				current_state <= next_state;
			end if;
		end if;	
	end process;
	
	process(seq_in, current_state)
	begin
		case (current_state) is
		when q0 =>
			if ( seq_in = '0' ) then
				next_state <= q0;
			else
				next_state <= q1;
			end if;
		when q1 =>
			if ( seq_in = '0' ) then
				next_state <= q2;
			else
				next_state <= q1;
			end if;
		when q2 =>
			if ( seq_in = '0' ) then
				next_state <= q0;
			else
				next_state <= q3;
			end if;
		when q3 =>
			if ( seq_in = '0' ) then
				next_state <= q4;
			else
				next_state <= q1;
			end if;
		when q4 =>
			if ( seq_in = '0' ) then
				next_state <= q0;
			else
				next_state <= q3;
			end if;
		end case;
	end process;					 			   
	
	process (current_state) is
	begin
		if (current_state = q4) then
			sum <= sum + 1;
		end if;
		detected_count <= sum;
	end process;
end behavioural;