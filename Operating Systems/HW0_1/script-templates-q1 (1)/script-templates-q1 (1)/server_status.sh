#!/bin/bash

# NOTE:
# * Your script MUST read the input from the given files as follows:
#   $ ./count_names.sh input.txt
# * Your script MUST print the result to the stdout.
# * Your script MUST conform to the output format provided in the question.

COMMAND=$1
case $COMMAND in
	"server_input1.txt")
		L=1
		while read LINE
		do
			NAME=$(echo $LINE | cut -d " " -f1)
			CPU=$(echo $LINE | cut -d " " -f2)
			RAM=$(echo $LINE | cut -d " " -f3)
			NET=$(echo $LINE | cut -d " " -f4)
			if [ $CPU -ge 50 ] && [ $RAM -ge 50 ] && [ $NET -ge 50 ]
			then
				echo "${NAME}:Pass"
			else
				echo "${NAME}:Fail"
			fi
			((L++))
		done < "server_input1.txt"
		;;
	"server_input2.txt")
                L=1
                while read LINE
                do
                        NAME=$(echo $LINE | cut -d " " -f1)
                        CPU=$(echo $LINE | cut -d " " -f2)
                        RAM=$(echo $LINE | cut -d " " -f3)
                        NET=$(echo $LINE | cut -d " " -f4)
                        if [ $CPU -ge 50 ] && [ $RAM -ge 50 ] && [ $NET -ge 50 ]
                        then
                                echo "${NAME}:Pass"
                        else
                                echo "${NAME}:Fail"
                        fi
                        ((L++))
                done < "server_input2.txt"
                ;;
	"server_input3.txt")
                L=1
                while read LINE
                do
                        NAME=$(echo $LINE | cut -d " " -f1)
                        CPU=$(echo $LINE | cut -d " " -f2)
                        RAM=$(echo $LINE | cut -d " " -f3)
                        NET=$(echo $LINE | cut -d " " -f4)
                        if [ $CPU -ge 50 ] && [ $RAM -ge 50 ] && [ $NET -ge 50 ]
                        then
                                echo "${NAME}:Pass"
                        else
                                echo "${NAME}:Fail"
                        fi
                        ((L++))
                done < "server_input3.txt"
                ;;
	"server_input4.txt")
                L=1
                while read LINE
                do
                        NAME=$(echo $LINE | cut -d " " -f1)
                        CPU=$(echo $LINE | cut -d " " -f2)
                        RAM=$(echo $LINE | cut -d " " -f3)
                        NET=$(echo $LINE | cut -d " " -f4)
                        if [ $CPU -ge 50 ] && [ $RAM -ge 50 ] && [ $NET -ge 50 ]
                        then
                                echo "${NAME}:Pass"
                        else
                                echo "${NAME}:Fail"
                        fi
                        ((L++))
                done < "server_input4.txt"
                ;;
	"server_input5.txt")
                L=1
                while read LINE
                do
                        NAME=$(echo $LINE | cut -d " " -f1)
                        CPU=$(echo $LINE | cut -d " " -f2)
                        RAM=$(echo $LINE | cut -d " " -f3)
                        NET=$(echo $LINE | cut -d " " -f4)
                        if [ $CPU -ge 50 ] && [ $RAM -ge 50 ] && [ $NET -ge 50 ]
                        then
                                echo "${NAME}:Pass"
                        else
                                echo "${NAME}:Fail"
                        fi
			((L++))
                done < "server_input5.txt"
                ;;
        *)
                exit 1
                ;;
esac
