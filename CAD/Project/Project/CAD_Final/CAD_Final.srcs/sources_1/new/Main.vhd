----------------------------------------------------------------------------------
-- Company: 
-- Engineer: 
-- 
-- Create Date: 01/25/2023 11:09:08 AM
-- Design Name: 
-- Module Name: Main - Behavioral
-- Project Name: 
-- Target Devices: 
-- Tool Versions: 
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
use work.pack.all ;
library std;
use std.textio.all;
-- Uncomment the following library declaration if using
-- arithmetic functions with Signed or Unsigned values
--use IEEE.NUMERIC_STD.ALL;

-- Uncomment the following library declaration if instantiating
-- any Xilinx leaf cells in this code.
--library UNISIM;
--use UNISIM.VComponents.all;

entity Main is
    generic (N : integer );
    Port ( clk : in STD_LOGIC 
           );
end Main;

architecture Behavioral of Main is
    component TileRow is
        Port (
            windowROw : in WindowRow_type ;
            Filter : in filter_type ;
            FMRow : out FMRow_type
        );
    end component ;

    type FMs_Type is array (0 to N-1) of FM_type ;
    --    signal result : FMs_Type ;

    type filters_Type is array (0 to N-1) of filter_type ;
    signal filters : filters_Type ;

    signal windows : WindowRow_type ;

    type FMRows_type is array (0 to N-1) of FMRow_type ;
    signal ResultFMRows : FMRows_type ;


begin

    TileRowsGen : for i in 0 to N-1 generate 
                    TR : TileRow port map(FMRow => ResultFMRows(i),
                         windowRow => windows , 
                         Filter => filters(i));
                  end generate ;


    process(clk)
        variable counter : integer := -1;
        variable m : boolean ;
        variable result : FMs_Type ;
        file file_var : text ;
        variable line_var : line;
        variable strdel : string (1 to 2) := ", ";
    begin
        if rising_edge(clk) then
            if not m then
                m := seed(150 , 240);
                for i in 0 to N-1 loop
                    filters(i) <= RandomFilterReal ;
                end loop;
                counter := counter +1;
            end if;
            if (counter < 127 and counter > -1)then

                if (counter > 0 and counter < 127) then
                    for i in 0 to N-1 loop
                        result(i)(counter-1) := ResultFMRows(i);
                    end loop;
                end if;
                if (counter > -1 and counter <126) then 
                    for i in 0 to 125 loop
                        windows(i) <= getWindow(counter,i);
                    end loop;
                    counter := counter +1;
                end if;
                
                if counter = 126 then
                 for g in 0 to N -1 loop 
                    file_open(file_var ,"C:\Users\Lenovo\Desktop\CAD_FMS\fm" & integer'image(g)& ".txt",WRITE_MODE);
                    for i in 0 to 125 loop 
                        for j in 0 to 125 loop 
                            write(line_var , integer (result(g)(i)(j)));
                            write (line_var , strdel );
                        end loop;
                        writeline (file_var , line_var );
                    end loop;
                    file_close(file_var );
                 end loop;
                end if;
            end if;



        end if;
    end process;

end Behavioral;
