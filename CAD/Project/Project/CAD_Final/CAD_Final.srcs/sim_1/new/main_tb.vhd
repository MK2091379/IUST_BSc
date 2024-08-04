library IEEE;
use IEEE.Std_logic_1164.all;
use IEEE.Numeric_Std.all;
use work.pack.all ;
entity Main_tb is
end;

architecture bench of Main_tb is

  component Main
      generic (N : integer );
      Port ( clk : in STD_LOGIC );
  end component;

  signal clk: STD_LOGIC;

  constant clock_period: time := 20 ns;
  signal stop_the_clock: boolean;
--  signal res : FMRow_type ;
begin

  -- Insert values for generic parameters !!
  uut: Main generic map ( N   => 10 )
               port map ( clk => clk );

  stimulus: process
  begin
  
    -- Put initialisation code here

    wait for 130* clock_period ;
    -- Put test bench stimulus code here

    stop_the_clock <= true;
    wait;
  end process;

  clocking: process
  begin
    while not stop_the_clock loop
      clk <= '0', '1' after clock_period / 2;
      wait for clock_period;
    end loop;
    wait;
  end process;

end;
  