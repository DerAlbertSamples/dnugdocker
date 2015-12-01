FROM microsoft/aspnet:1.0.0-rc1-final-coreclr

COPY ./output /app
WORKDIR /app

# Open this port in the container
EXPOSE 5500
# Start application
ENTRYPOINT ["./approot/web"]