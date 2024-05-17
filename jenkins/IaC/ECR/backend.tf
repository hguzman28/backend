terraform {
  backend "s3" {
    bucket = "terraform-state"
    key    = "state/backend/cor/"
    region = "us-east-1"
  }
}