# Use the official .NET 8 SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:8.0

# Set the working directory
# WORKDIR /workspace

# Install any additional tools or dependencies needed for your project
# For example, you can install Node.js, npm, or other packages here
RUN sh -c "$(curl --location https://taskfile.dev/install.sh)" -- -d -b /usr/local/bin

# Expose the necessary ports (if required by your project)
# EXPOSE 5000

# Switch to non-root user
# USER nobody

# Start a shell session (you can customize this based on your needs)
CMD ["/bin/bash"]
