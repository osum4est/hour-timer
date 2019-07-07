package main.java

import javafx.application.Application
import javafx.fxml.FXMLLoader
import javafx.scene.Parent
import javafx.scene.Scene
import javafx.scene.text.Font
import javafx.stage.Stage

class Runtime : Application() {
    companion object {
        val VERSION: String = "v1.0.0"
        val COPYRIGHT: String = "© Forrest Jones 2019"

        @JvmStatic
        fun main() {
            launch(Runtime::class.java)
        }
    }

    override fun start(primaryStage: Stage?) {
        Font.loadFont(javaClass.getResourceAsStream("/font/roboto/Roboto-Regular.ttf"), 10.0)

        val root: Parent = FXMLLoader.load(javaClass.getResource("../resources/view/MainWindow.fxml"))
        primaryStage?.title = "Runtime"
        primaryStage?.scene = Scene(root)
        primaryStage?.show()
    }
}

