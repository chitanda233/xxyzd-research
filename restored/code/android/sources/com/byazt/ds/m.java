package com.byazt.ds;

import android.content.Context;
import android.content.pm.PackageInfo;
import android.text.TextUtils;
import com.byazt.quv.AbsServerManager;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1480, MediaPlayer.MEDIA_PLAYER_OPTION_DEFAULT_VIDEO_BITRATE})
public class m extends ve {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public final x f806a;
    public final Context n;

    public m(Context context, x xVar) {
        super(false, false);
        this.n = context;
        this.f806a = xVar;
    }

    @Override // com.byazt.ds.ve
    public boolean c(JSONObject jSONObject) throws JSONException {
        int i;
        int i2;
        String packageName = this.n.getPackageName();
        PackageInfo packageInfo = null;
        if (TextUtils.isEmpty(this.f806a.lr())) {
            jSONObject.put(AbsServerManager.PACKAGE_QUERY_BINDER, packageName);
        } else {
            if (com.byazt.yv.da.tt) {
                com.byazt.yv.da.c("has zijie pkg", null);
            }
            jSONObject.put(AbsServerManager.PACKAGE_QUERY_BINDER, this.f806a.lr());
            jSONObject.put("real_package_name", packageName);
        }
        try {
            packageInfo = this.n.getPackageManager().getPackageInfo(packageName, 0);
        } catch (Throwable unused) {
        }
        if (packageInfo != null) {
            try {
                i = packageInfo.versionCode;
            } catch (Throwable th) {
                com.byazt.yv.da.tt(th);
                return false;
            }
        } else {
            i = 0;
        }
        if (!TextUtils.isEmpty(this.f806a.zb())) {
            jSONObject.put(com.sigmob.sdk.base.n.r, this.f806a.zb());
        } else {
            jSONObject.put(com.sigmob.sdk.base.n.r, packageInfo != null ? packageInfo.versionName : "");
        }
        if (!TextUtils.isEmpty(this.f806a.pf())) {
            jSONObject.put("app_version_minor", this.f806a.pf());
        } else {
            jSONObject.put("app_version_minor", "");
        }
        if (this.f806a.h() != 0) {
            jSONObject.put("version_code", this.f806a.h());
        } else {
            jSONObject.put("version_code", i);
        }
        if (this.f806a.d() != 0) {
            jSONObject.put("update_version_code", this.f806a.d());
        } else {
            jSONObject.put("update_version_code", i);
        }
        if (this.f806a.eo() != 0) {
            jSONObject.put("manifest_version_code", this.f806a.eo());
        } else {
            jSONObject.put("manifest_version_code", i);
        }
        if (!TextUtils.isEmpty(this.f806a.md())) {
            jSONObject.put("app_name", this.f806a.md());
        }
        if (!TextUtils.isEmpty(this.f806a.or())) {
            jSONObject.put("tweaked_channel", this.f806a.or());
        }
        if (packageInfo == null || packageInfo.applicationInfo == null || (i2 = packageInfo.applicationInfo.labelRes) <= 0) {
            return true;
        }
        jSONObject.put("display_name", this.n.getString(i2));
        return true;
    }
}
