resource "aws_ecr_repository" "repository_docker" {
  name                 = var.name_repository
  image_tag_mutability = "MUTABLE"

  image_scanning_configuration {
    scan_on_push = true
  }
}

variable "name_repository" {
  
}