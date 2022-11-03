package bowling;

import static org.junit.jupiter.api.Assertions.assertEquals;

import java.util.Arrays;

import org.junit.jupiter.api.Test;

public class BowlingTest {

    @Test
    public void emptyGame() {
        Game game = new Game();
        int score = game.score(Arrays.asList());
        assertEquals(0, score);
    }
}
