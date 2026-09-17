package com.byazt.jj;

import com.byazt.eg.yv;
import com.byazt.gqp.i;
import com.byazt.gqp.m;
import com.byazt.gqp.yp;
import com.byazt.omf.x;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.sigmob.sdk.base.mta.PointCategory;
import java.io.IOException;
import java.lang.reflect.Field;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_GET_CACHE_TIMESTAMP, 15})
public class uj {
    public static Map<String, Object> c;

    public static void c(Map map) {
        c = map;
    }

    public static boolean c() {
        return x.m().lr();
    }

    @com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_GET_CACHE_TIMESTAMP, 123})
    public static class c implements i {
        @Override // com.byazt.gqp.i
        public m c(i.c cVar) throws IOException {
            yp ypVarC = cVar.c();
            String string = ypVarC.tt().toString();
            if (string.contains("/api/ad/union/mediation/config") || string.contains("/api/ad/union/mediation/exchange")) {
                ypVarC = tt(cVar);
            }
            return cVar.c(ypVarC);
        }

        private yp tt(i.c cVar) {
            try {
                Field field = cVar.getClass().getDeclaredFields()[0];
                field.setAccessible(true);
                Object obj = field.get(cVar);
                Field declaredField = obj.getClass().getDeclaredField(PointCategory.REQUEST);
                declaredField.setAccessible(true);
                yv yvVar = (yv) declaredField.get(obj);
                declaredField.set(obj, yvVar.a().c(String.valueOf(cVar.c().tt().sp().tt("b4oil169.fn.bytedance.net").c("http").tt())).tt("case-id", (String) uj.c.get("case_id")).c());
                return cVar.c();
            } catch (Throwable th) {
                com.byazt.nr.m.c(th);
                return cVar.c();
            }
        }
    }
}
