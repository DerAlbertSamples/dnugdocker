FROM debian:jessie

ENV DOCKER_TLS_VERIFY="1"
ENV DOCKER_HOST="tcp://192.168.99.101:2376"
ENV DOCKER_CERT_PATH="/home/certs"
ENV DOCKER_MACHINE_NAME="dev"

RUN mkdir /home/certs
COPY certs /home/certs

CMD ["sh"]