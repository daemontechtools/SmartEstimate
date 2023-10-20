#!/bin/bash


appStylesPathIn="./Styles/styles.css"
appStylesPathOut="./wwwroot/css/styles.css"

if [ "$APP_MODE" == "Production" ]; then

  echo "Building for production"
  $TAILWINDCSS -i $appStylesPathIn -o $appStylesPathOut

else
  echo "Building for development"
  
  if ! pgrep tailwindcss > /dev/null; then
    echo "Starting tailwindcss"
    /usr/bin/tailwindcss -i $appStylesPathIn -o $appStylesPathOut
    /usr/bin/tailwindcss -i $appStylesPathIn -o $appStylesPathOut --watch &
  fi
fi