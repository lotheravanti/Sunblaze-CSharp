 pipeline {
  agent any

  stages {
    stage("Build") {
      steps {
        checkout scmGit(branches: [[name: 'main']], 
                                userRemoteConfigs: [[url: 'https://github.com/lotheravanti/Sunblaze-CSharp']])
        bat'''
        echo "Build"
        cd SunblazeFE
        dotnet clean SunblazeFE.sln
        dotnet build SunblazeFE.sln
        dotnet tool install --global Microsoft.Playwright.CLI
        cd SunblazeFE
        playwright install
        '''
      }
    }

    stage("Test") {
      steps {
        echo "Run Tests"
        bat'''
        dotnet test "SunblazeFE/SunblazeFE/bin/Debug/net8.0/SunblazeFE.dll"
        '''
      }
    }
  }
}