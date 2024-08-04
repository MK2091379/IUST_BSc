#!/bin/bash
doing(){
        L=$1
        local MYCOUNTER=0
        while read -r LINE
        do
           local temp=$(echo $LINE | tr '\t' ' ' | tr ',' ' ' | tr '|' ' ' | tr '!' ' ' | tr '$' ' ' | tr '\n' ' ' | tr '\\' ' ' )
           read -a arr <<<$temp
          MYCOUNTER=$((MYCOUNTER + ${#arr[@]}))
        done< <(grep "" $L)
        echo "count: $MYCOUNTER"
}
doing $1   
