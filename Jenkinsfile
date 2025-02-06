 pipeline {
  agent any

  stages {
    stage("Hello") {
      steps {
        echo "Hello"
      }
    }

    stage("Testing") {
      parallel {
        stage("Unit Tests") {
          steps {
            echo "Hello"
          }
    }

    stage("Deploy") {
      steps {
        echo "Deploy!"
      }
    }
  }
}