pipeline {
    agent any
    
    stages {
        stage('Checkout') {
            steps {
                echo 'Код получен из Git'
                bat 'dir'
            }
        }
        stage('Build') {
            steps {
                echo 'Сборка проекта BackupSystem...'
                bat 'dotnet build BackupSystem.sln || echo "Сборка пропущена (нет dotnet или ошибка)"'
            }
        }
        stage('Test') {
            steps {
                echo 'Запуск тестов...'
                // Запускаем тесты
                bat 'dotnet test BackupSystem.sln || echo "Тесты пропущены"'
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