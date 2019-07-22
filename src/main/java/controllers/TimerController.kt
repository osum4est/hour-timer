package main.java.controllers

import javafx.application.Platform
import javafx.beans.binding.Bindings
import javafx.beans.property.SimpleDoubleProperty
import javafx.beans.property.SimpleStringProperty
import javafx.fxml.FXML
import javafx.geometry.Insets
import javafx.scene.control.Label
import javafx.scene.layout.VBox
import java.time.*
import java.util.*
import java.util.concurrent.Callable
import kotlin.concurrent.timerTask

class TimerController() {
    @FXML
    lateinit var container: VBox

    @FXML
    lateinit var countDownHourMinute: Label

    @FXML
    lateinit var countUpHourMinute: Label

    @FXML
    lateinit var countDownSecond: Label

    @FXML
    lateinit var countUpSecond: Label

    @FXML
    lateinit var message: Label

    var raceName: String = ""
    var length: Int = 0
    var startDate: LocalDate = LocalDate.now()
    var startTime: LocalTime = LocalTime.now()

    var timerThread: TimerTask? = null

    @FXML
    fun initialize() {
        val hourMinuteFontSize = SimpleDoubleProperty()
        hourMinuteFontSize.bind(container.widthProperty().divide(7))
        val hourMinuteBinding =
            Bindings.concat("-fx-font-size: ", hourMinuteFontSize.asString(), ";", "-fx-font-family: monospaced;")

        countDownHourMinute.styleProperty().bind(hourMinuteBinding)
        countUpHourMinute.styleProperty().bind(hourMinuteBinding)

        val secondFontSize = SimpleDoubleProperty()
        secondFontSize.bind(container.widthProperty().divide(18))
        val secondBinding =
            Bindings.concat("-fx-font-size: ", secondFontSize.asString(), ";", "-fx-font-family: monospaced;")

        val secondPadding = SimpleDoubleProperty()
        secondPadding.bind(secondFontSize.divide(2.5))
        val secondPaddingBinding =
            Bindings.createObjectBinding((Callable { Insets(secondPadding.value, 0.0, 0.0, 0.0) }), secondPadding)

        countDownSecond.styleProperty().bind(secondBinding)
        countUpSecond.styleProperty().bind(secondBinding)
        countDownSecond.paddingProperty().bind(secondPaddingBinding)
        countUpSecond.paddingProperty().bind(secondPaddingBinding)

        val messageFontSize = SimpleDoubleProperty()
        messageFontSize.bind(container.widthProperty().divide(50))
        val messageBinding =
            Bindings.concat("-fx-font-size: ", messageFontSize.asString(), ";", "-fx-font-family: monospaced;")

        message.styleProperty().bind(messageBinding)

        val timer = Timer(false)
        val timerStart = LocalDateTime.now().withNano(0).plusSeconds(1)
        timerThread = timerTask {
            val start = LocalDateTime.of(startDate, startTime)
            val end = LocalDateTime.of(startDate, startTime).plusHours(length.toLong())
            val current = LocalDateTime.now()

            Platform.runLater {
                message.text = raceName

                if (current < start) {
                    val countDown = Duration.between(current, start)
                    countDownHourMinute.text = "-" + getHourText(countDown)
                    countDownSecond.text = getSecondText(countDown)
                    countUpHourMinute.text = "-" + getHourText(countDown)
                    countUpSecond.text = getSecondText(countDown)
                } else if (current > end) {
                    val countUp = Duration.between(end, current)
                    countDownHourMinute.text = "+" + getHourText(countUp)
                    countDownSecond.text = getSecondText(countUp)
                    countUpHourMinute.text = "+" + getHourText(countUp)
                    countUpSecond.text = getSecondText(countUp)
                } else {
                    val countDown = Duration.between(current, end)
                    val countUp = Duration.between(start, current)
                    countDownHourMinute.text = "-" + getHourText(countDown)
                    countDownSecond.text = getSecondText(countDown)
                    countUpHourMinute.text = "+" + getHourText(countUp)
                    countUpSecond.text = getSecondText(countUp)
                }
            }
        }

        timer.schedule(timerThread, Date(timerStart.atZone(ZoneId.systemDefault()).toEpochSecond()), 1000)
    }

    private fun getHourText(duration: Duration): String {
        return duration.toHours().toString().padStart(3, '0') + ":" +
                (duration.toMinutes() - duration.toHours() * 60).toString().padStart(2, '0')
    }

    private fun getSecondText(duration: Duration): String {
        return ":" +
                (duration.seconds - duration.toMinutes() * 60).toString().padStart(2, '0')
    }

    fun stopTimer() {
        timerThread?.cancel()
    }
}