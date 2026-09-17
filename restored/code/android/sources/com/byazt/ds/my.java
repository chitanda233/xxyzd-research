package com.byazt.ds;

import android.content.Context;
import android.content.pm.PackageInfo;
import android.content.pm.Signature;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1480, MediaPlayer.MEDIA_PLAYER_OPTION_SINGLE_PLAY_DOWNLOAD_BYTES})
public class my extends ve {
    public final Context n;

    public my(Context context) {
        super(true, false);
        this.n = context;
    }

    @Override // com.byazt.ds.ve
    public boolean c(JSONObject jSONObject) throws JSONException {
        PackageInfo packageInfo;
        Signature signature;
        String strTt = null;
        try {
            packageInfo = this.n.getPackageManager().getPackageInfo(this.n.getPackageName(), 64);
        } catch (Throwable th) {
            com.byazt.yv.da.tt(th);
            packageInfo = null;
        }
        if (packageInfo != null && packageInfo.signatures != null && packageInfo.signatures.length > 0 && (signature = packageInfo.signatures[0]) != null) {
            strTt = com.byazt.yv.ve.tt(signature.toByteArray());
        }
        if (strTt == null) {
            return true;
        }
        jSONObject.put("sig_hash", strTt);
        return true;
    }
}
