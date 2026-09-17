package com.byazt.vm;

import android.content.SharedPreferences;
import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.UUID;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_SUPER_RES_OPTION, 15})
public final class uj {
    public static tt<String> c = new tt<String>() { // from class: com.byazt.vm.uj.1
        @Override // com.byazt.vm.tt
        /* JADX INFO: renamed from: ve, reason: merged with bridge method [inline-methods] */
        public String c(Object... objArr) {
            SharedPreferences sharedPreferences = (SharedPreferences) objArr[0];
            String string = sharedPreferences.getString("cdid", "");
            if (!TextUtils.isEmpty(string)) {
                return string;
            }
            String string2 = UUID.randomUUID().toString();
            sharedPreferences.edit().putString("cdid", string2).apply();
            return string2;
        }
    };

    public static String c(SharedPreferences sharedPreferences) {
        return c.tt(sharedPreferences);
    }
}
