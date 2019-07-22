package main.java.controllers

import com.jfoenix.controls.JFXDatePicker
import com.jfoenix.controls.JFXTextField
import com.jfoenix.controls.JFXTimePicker
import javafx.event.ActionEvent
import javafx.fxml.FXML
import javafx.fxml.FXMLLoader
import javafx.scene.Node
import javafx.scene.Parent
import javafx.scene.Scene
import javafx.scene.control.Label
import javafx.stage.Screen
import javafx.stage.Stage
import main.java.Runtime
import main.java.controls.JFXNumberField
import java.time.LocalDate
import java.time.LocalTime
import javafx.stage.Screen.getPrimary
import javafx.stage.WindowEvent
import javax.swing.Action


class MainWindowController {
    @FXML
    lateinit var copyright: Label

    @FXML
    lateinit var version: Label

    @FXML
    lateinit var raceName: JFXTextField

    @FXML
    lateinit var length: JFXNumberField

    @FXML
    lateinit var startDate: JFXDatePicker

    @FXML
    lateinit var startTime: JFXTimePicker

    @FXML
    fun initialize() {
        copyright.text = Runtime.COPYRIGHT
        version.text = Runtime.VERSION
        loadData()
    }

    fun showLargeTimer(actionEvent: ActionEvent) {
        if (!validate())
            return

        saveData()

        val stage = showTimer(actionEvent)

        stage.isFullScreen = true
    }

    fun showSmallTimer(actionEvent: ActionEvent) {
        if (!validate())
            return

        saveData()

        val stage = showTimer(actionEvent)

        val primaryScreenBounds = Screen.getPrimary().visualBounds
        val width = 500.0
        val height = width * 9.0 / 16.0

        stage.width = width
        stage.height = height
        stage.x = primaryScreenBounds.maxX - width - 20
        stage.y = primaryScreenBounds.maxY - height - 20
        stage.isAlwaysOnTop = true
    }

    private fun showTimer(e: ActionEvent): Stage {
        val loader = FXMLLoader(javaClass.getResource("../../resources/view/Timer.fxml"))
        val root: Parent = loader.load()
        val stage = Stage()

        val controller = loader.getController<TimerController>()
        controller.raceName = raceName.text
        controller.length = Integer.parseInt(length.text)
        controller.startDate = startDate.value
        controller.startTime = startTime.value

        val mainWindowStage = (e.source as Node).scene.window as Stage
        stage.scene = Scene(root)
        stage.setOnHidden {
            stage.hide()
            mainWindowStage.show()
            controller.stopTimer()
        }

        stage.show()
        mainWindowStage.hide()

        return stage
    }

    private fun validate(): Boolean {
        // Prevent short circuiting
        return raceName.validate() and
                length.validate() and
                startDate.validate() and
                startTime.validate()
    }

    private fun loadData() {
        raceName.text = Runtime.PREFS.get(raceName.id, "")
        length.text = Runtime.PREFS.get(length.id, "")
        startDate.value = LocalDate.ofEpochDay(Runtime.PREFS.getLong(startDate.id, LocalDate.now().toEpochDay()))
        startTime.value = LocalTime.ofNanoOfDay(Runtime.PREFS.getLong(startTime.id, LocalTime.now().toNanoOfDay()))
    }

    private fun saveData() {
        Runtime.PREFS.put(raceName.id, raceName.text)
        Runtime.PREFS.put(length.id, length.text)
        Runtime.PREFS.putLong(startDate.id, startDate.value.toEpochDay())
        Runtime.PREFS.putLong(startTime.id, startTime.value.toNanoOfDay())
    }
}