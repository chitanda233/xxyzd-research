package com.byazt.fz;

import cn.thinkingdata.core.router.TRouterMap;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1022, MediaPlayer.MEDIA_PLAYER_OPTION_DISABLE_ACCURATE_START})
public class z implements sl {
    @Override // com.byazt.fz.sl
    /* JADX INFO: renamed from: tt, reason: merged with bridge method [inline-methods] */
    public Number c(JSONObject jSONObject, Object[] objArr) {
        Object obj;
        if (objArr == null || objArr.length == 0 || (obj = objArr[0]) == null) {
            return null;
        }
        if (obj instanceof Number) {
            return (Number) obj;
        }
        if (obj instanceof Boolean) {
            return Integer.valueOf(((Boolean) obj).booleanValue() ? 1 : 0);
        }
        if (!(obj instanceof String)) {
            return null;
        }
        try {
            String strTrim = ((String) obj).trim();
            if (!strTrim.equalsIgnoreCase("true") && !strTrim.equalsIgnoreCase("false")) {
                if (strTrim.contains(TRouterMap.DOT)) {
                    return Double.valueOf(Double.parseDouble(strTrim));
                }
                return Long.valueOf(Long.parseLong(strTrim));
            }
            return null;
        } catch (NumberFormatException unused) {
            return null;
        }
    }
}
