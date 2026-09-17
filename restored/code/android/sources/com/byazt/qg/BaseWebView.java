package com.byazt.qg;

import android.content.Context;
import android.os.Looper;
import android.util.AttributeSet;
import android.view.View;
import android.webkit.DownloadListener;
import android.webkit.WebChromeClient;
import android.webkit.WebSettings;
import android.webkit.WebView;
import androidx.core.app.NotificationCompat;
import com.byazt.nl.ve;
import com.byazt.nr.da;
import com.byazt.nr.m;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_GET_CUR_UI_FPS, MediaPlayer.MEDIA_PLAYER_OPTION_ENABLE_DEMUXER_STALL})
public class BaseWebView extends WebView {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public View.OnScrollChangeListener f1351a;
    public Map<String, c> c;
    public Boolean da;
    public Boolean gr;
    public Boolean gt;
    public Boolean gu;
    public ve.c h;
    public Boolean i;
    public String m;
    public Boolean md;
    public Boolean my;
    public Integer n;
    public Boolean nu;
    public Boolean p;
    public Boolean qy;
    public WebSettings.LayoutAlgorithm rh;
    public Boolean rl;
    public Boolean sl;
    public Boolean sp;
    public Boolean t;
    public com.byazt.el.tt tt;
    public Boolean u;
    public DownloadListener uj;
    public WebChromeClient ve;
    public Boolean x;
    public Integer yp;
    public Boolean yv;
    public Integer z;
    public Integer zm;

    public ve.c getOnTouchEventListener() {
        return this.h;
    }

    public Map<String, c> getJavascriptInterfaces() {
        return this.c;
    }

    public com.byazt.el.tt getClient() {
        return this.tt;
    }

    public WebChromeClient getChromeClient() {
        return this.ve;
    }

    public View.OnScrollChangeListener getOnScrollChangeListener() {
        return this.f1351a;
    }

    public Boolean getMediaPlaybackRequiresUserGesture() {
        return this.sp;
    }

    public Boolean getSavePassword() {
        return this.x;
    }

    public Boolean getAllowUniversalAccessFromFileURLs() {
        return this.i;
    }

    public Boolean getAllowFileAccessFromFileURLs() {
        return this.da;
    }

    public Boolean getBlockNetworkImage() {
        return this.sl;
    }

    public Boolean getAllowFileAccess() {
        return this.t;
    }

    public Boolean getDatabaseEnabled() {
        return this.u;
    }

    public Integer getMixedContentMode() {
        return this.yp;
    }

    public Integer getDefaultFontSize() {
        return this.z;
    }

    public String getDefaultTextEncodingName() {
        return this.m;
    }

    public Boolean getLoadWithOverviewMod() {
        return this.nu;
    }

    public WebSettings.LayoutAlgorithm getLayoutAlgorithm() {
        return this.rh;
    }

    public Boolean getBuiltInZoomControls() {
        return this.my;
    }

    public Boolean getDomStorageEnabled() {
        return this.gt;
    }

    public Boolean getJavaScriptCanOpenWindowsAutomatically() {
        return this.rl;
    }

    public Boolean getSupportZoom() {
        return this.qy;
    }

    public Boolean getUseWideViewPort() {
        return this.gu;
    }

    public Boolean getAppCacheEnabled() {
        return this.gr;
    }

    public Integer getCacheMode() {
        return this.zm;
    }

    public Boolean getDisplayZoomControls() {
        return this.yv;
    }

    public Boolean getJavaScriptEnabled() {
        return this.p;
    }

    public Boolean getNetworkAvailable() {
        return this.md;
    }

    public BaseWebView(Context context) {
        super(context);
        this.f1351a = null;
    }

    public BaseWebView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.f1351a = null;
    }

    public BaseWebView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.f1351a = null;
    }

    public void c(Runnable runnable) {
        if (c()) {
            runnable.run();
        } else {
            da.tt().post(runnable);
        }
    }

    public boolean c() {
        return Looper.getMainLooper() == Looper.myLooper();
    }

    public DownloadListener getDownloadListener() {
        return this.uj;
    }

    public Integer getBackgroundColor() {
        return this.n;
    }

    public void tt() {
        this.c = null;
        this.tt = null;
        this.ve = null;
        this.uj = null;
        this.f1351a = null;
        this.n = null;
        this.sp = null;
        this.x = null;
        this.i = null;
        this.da = null;
        this.sl = null;
        this.t = null;
        this.u = null;
        this.yp = null;
        this.z = null;
        this.m = null;
        this.nu = null;
        this.rh = null;
        this.my = null;
        this.gt = null;
        this.rl = null;
        this.qy = null;
        this.gu = null;
        this.gr = null;
        this.zm = null;
        this.yv = null;
        this.p = null;
        this.md = null;
        this.h = null;
    }

    @Override // android.webkit.WebView
    public void destroy() {
        tt();
        super.destroy();
    }

    public void c(String str, String str2, JSONObject jSONObject) {
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.putOpt("__msg_type", "callback");
            jSONObject2.putOpt("__callback_id", str2);
            jSONObject2.putOpt("__params", jSONObject);
            c(str, jSONObject2);
        } catch (Throwable th) {
            m.c(th);
        }
    }

    public void tt(String str, String str2, JSONObject jSONObject) {
        try {
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.putOpt("__msg_type", NotificationCompat.CATEGORY_EVENT);
            jSONObject2.putOpt("__event_id", str2);
            jSONObject2.putOpt("__params", jSONObject);
            c(str, jSONObject2);
        } catch (Throwable th) {
            m.c(th);
        }
    }

    private void c(String str, JSONObject jSONObject) {
        evaluateJavascript("javascript:" + str + "._handleMessageFromToutiao(" + jSONObject + ")", null);
    }
}
