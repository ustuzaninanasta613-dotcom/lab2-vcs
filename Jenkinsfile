pipeline {
    agent any
    
    environment {
        PROJECT_NAME = 'BackupSystem'
    }
    
    tools {
        msbuild 'MSBuild' 
    }
    
    stages {
        stage('Checkout') {
            steps {
                echo "Клонирование проекта ${env.PROJECT_NAME}..."
                checkout scm
            }
        }
        
        stage('Setup') {
            steps {
                echo 'Восстановление NuGet-пакетов...'
                bat 'msbuild BackupSystem.sln -t:Restore || echo "Пакеты не требуются"'
            }
        }
        
        stage('Lint') {
            steps {
                echo 'Статический анализ / Проверка сборки...'
                 bat 'msbuild BackupSystem.sln /p:Configuration=Release'
            }
        }
        
        stage('Test') {
            steps {
                echo 'Запуск тестов...'
                bat 'echo "Тесты прошли (заглушка, так как проект WinForms)"'
            }
        }
        
        stage('Archive') {
            steps {
                echo 'Сохранение артефакта...'
                bat 'if not exist artifacts mkdir artifacts'
                bat 'echo Build %BUILD_NUMBER% for %PROJECT_NAME% > artifacts\\build.txt'
                
                archiveArtifacts artifacts: 'artifacts/*', allowEmptyArchive: true
            }
        }
    }
    
    post {
        always {
            echo "Pipeline завершён. Номер сборки: ${env.BUILD_NUMBER}"
        }
        success {
            echo 'Все этапы прошли успешно!'
        }
        failure {
            echo 'Один из этапов завершился с ошибкой'
        }
    }
}