package com.tencent.turingfd.sdk.ams.ad;

import android.text.TextUtils;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.HashMap;
import java.util.Locale;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Durian {
    public static Dew b(int i) {
        String strA;
        int i2;
        int i3;
        int i4;
        String str;
        int i5;
        int i6;
        String str2;
        try {
            strA = a(i);
            try {
                if (i != -1) {
                    str2 = new String(CanisMinor.a(String.format(Locale.SIMPLIFIED_CHINESE, "/proc/%d/status", Integer.valueOf(i))));
                } else {
                    Locale locale = Locale.SIMPLIFIED_CHINESE;
                    str2 = new String(CanisMinor.a("/proc/self/status"));
                }
                HashMap map = new HashMap();
                for (String str3 : str2.split("\n")) {
                    String[] strArrSplit = str3.split(":");
                    if (strArrSplit.length >= 2) {
                        map.put(strArrSplit[0].trim(), strArrSplit[1].trim());
                    }
                }
                i2 = Integer.parseInt((String) map.get("PPid"));
                try {
                    i3 = Integer.parseInt(((String) map.get("Uid")).split("\\s+")[0]);
                    try {
                        str = strA;
                        i5 = i2;
                        i6 = i3;
                        i4 = Integer.parseInt((String) map.get("TracerPid"));
                    } catch (Throwable unused) {
                        i4 = -1;
                        str = strA;
                        i5 = i2;
                        i6 = i3;
                    }
                } catch (Throwable unused2) {
                    i3 = -1;
                }
            } catch (Throwable unused3) {
                i2 = -1;
                i3 = -1;
                i4 = -1;
                str = strA;
                i5 = i2;
                i6 = i3;
                return str != null ? null : null;
            }
        } catch (Throwable unused4) {
            strA = null;
        }
        if (str != null || i5 == -1 || i6 == -1) {
            return null;
        }
        return new Dew(i, i5, str, i6, i4);
    }

    public static String a(int i) {
        String str;
        byte[] bArrA;
        int i2;
        try {
            Locale locale = Locale.SIMPLIFIED_CHINESE;
            int i3 = 0;
            byte[] bArrA2 = CanisMinor.a(String.format(locale, "/proc/%d/cmdline", Integer.valueOf(i)), 100);
            if (bArrA2 != null) {
                int i4 = -1;
                while (true) {
                    i2 = i4 + 1;
                    if (i4 >= bArrA2.length) {
                        i2 = 0;
                        break;
                    }
                    if (i2 == bArrA2.length || bArrA2[i2] == 0) {
                        break;
                        break;
                    }
                    i4 = i2;
                }
                str = new String(bArrA2, 0, i2);
            } else {
                str = "";
            }
            if (!TextUtils.isEmpty(str) || (bArrA = CanisMinor.a(String.format(locale, "/proc/%d/status", Integer.valueOf(i)), MediaPlayer.MEDIA_PLAYER_OPTION_GET_VIDEO_OUTPUT_FPS)) == null) {
                return str;
            }
            int i5 = 6;
            while (true) {
                int i6 = i5 + 1;
                if (i5 < bArrA.length) {
                    if (i6 != bArrA.length && bArrA[i6] != 10) {
                        i5 = i6;
                    }
                    i3 = i6;
                    break;
                }
                break;
            }
            return i3 == 0 ? "" : new String(bArrA, 6, i3 - 6);
        } catch (Throwable th) {
            th.printStackTrace();
            return "";
        }
    }
}
