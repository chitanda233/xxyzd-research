package com.byazt.fs;

import android.graphics.Path;
import android.util.JsonReader;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.io.IOException;
import java.util.Collections;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 720, MediaPlayer.MEDIA_PLAYER_OPTION_DEFAULT_VIDEO_BITRATE})
public class m {
    public static com.byazt.jx.n c(JsonReader jsonReader, com.byazt.ga.a aVar) throws IOException {
        com.byazt.kd.uj ujVarTt = null;
        Path.FillType fillType = Path.FillType.WINDING;
        String strNextString = null;
        com.byazt.jx.sp spVar = null;
        com.byazt.kd.ve veVarC = null;
        com.byazt.kd.a aVarVe = null;
        com.byazt.kd.a aVarVe2 = null;
        boolean zNextBoolean = false;
        while (jsonReader.hasNext()) {
            String strNextName = jsonReader.nextName();
            strNextName.hashCode();
            int iNextInt = -1;
            switch (strNextName) {
                case "e":
                    aVarVe2 = uj.ve(jsonReader, aVar);
                    break;
                case "g":
                    jsonReader.beginObject();
                    while (jsonReader.hasNext()) {
                        String strNextName2 = jsonReader.nextName();
                        strNextName2.hashCode();
                        if (strNextName2.equals(com.kuaishou.weapon.p0.t.f2732a)) {
                            veVarC = uj.c(jsonReader, aVar, iNextInt);
                        } else if (strNextName2.equals(com.kuaishou.weapon.p0.t.b)) {
                            iNextInt = jsonReader.nextInt();
                        } else {
                            jsonReader.skipValue();
                        }
                    }
                    jsonReader.endObject();
                    break;
                case "o":
                    ujVarTt = uj.tt(jsonReader, aVar);
                    break;
                case "r":
                    fillType = jsonReader.nextInt() == 1 ? Path.FillType.WINDING : Path.FillType.EVEN_ODD;
                    break;
                case "s":
                    aVarVe = uj.ve(jsonReader, aVar);
                    break;
                case "t":
                    spVar = jsonReader.nextInt() == 1 ? com.byazt.jx.sp.LINEAR : com.byazt.jx.sp.RADIAL;
                    break;
                case "hd":
                    zNextBoolean = jsonReader.nextBoolean();
                    break;
                case "nm":
                    strNextString = jsonReader.nextString();
                    break;
                default:
                    jsonReader.skipValue();
                    break;
            }
        }
        return new com.byazt.jx.n(strNextString, spVar, fillType, veVarC, ujVarTt == null ? new com.byazt.kd.uj(Collections.singletonList(new com.byazt.vc.c(100))) : ujVarTt, aVarVe, aVarVe2, null, null, zNextBoolean);
    }
}
