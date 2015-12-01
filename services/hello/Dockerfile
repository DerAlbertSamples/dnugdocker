FROM microsoft/aspnet:1.0.0-rc1-final-coreclr

COPY ./src /app
WORKDIR /app
RUN ["dnu","restore"]

# Open this port in the container
EXPOSE 5501
# Start application
ENTRYPOINT ["dnx","-p","./hello", "web"]