#!/bin/bash

tailwindPath="/usr/bin/tailwindcss"
appStylesPathIn="./Styles/main.css"
appStylesPathOut="./wwwroot/css/bundle.css"


if ! pgrep tailwindcss > /dev/null; then
  nohup $tailwindPath -i $appStylesPathIn -o $appStylesPathOut --watch > /dev/null 2>&1 &
fi