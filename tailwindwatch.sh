#!/bin/bash

tailwindPath="/usr/bin/tailwindcss"
appStylesPathIn="./Styles/app.css"
appStylesPathOut="./wwwroot/app.css"

if ! pgrep tailwindcss > /dev/null; then
  nohup $tailwindPath -i $appStylesPathIn -o $appStylesPathOut --watch > /dev/null 2>&1 &
fi