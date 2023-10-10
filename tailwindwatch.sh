#!/bin/bash

tailwindPath="/usr/bin/tailwindcss"
appStylesPathIn="./Styles/bundle.css"
appStylesPathOut="./wwwroot/css/bundle.css"


$tailwindPath -i $appStylesPathIn -o $appStylesPathOut
