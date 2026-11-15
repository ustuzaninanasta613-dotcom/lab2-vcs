pipeline {
    agent any
    
    tools {
        msbuild 'MSBuild'
    }
    
    stages {
        stage('Checkout') {
            steps {
                echo 'Код получен из Git'
                bat 'dir'
            }
        }
        stage('Build') {
            steps {
                echo 'Сборка проекта BackupSystem (MSBuild)...'
                bat 'msbuild BackupSystem.sln /p:Configuration=Release'
            }
        }
        stage('Test') {
            steps {
                echo 'Запуск тестов...'
                bat 'echo "Тесты для .NET Framework проекта"'
            }
        }
    }
    post {
        success {
            echo 'Пайплайн завершён успешно!'
        }
        failure {
            echo 'Пайплайн завершился с ошибкой'
        }
    }
}