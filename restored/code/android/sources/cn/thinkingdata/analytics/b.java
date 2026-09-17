package cn.thinkingdata.analytics;

import android.app.Activity;
import android.app.Dialog;
import android.app.Fragment;
import android.view.View;
import android.webkit.WebView;
import cn.thinkingdata.analytics.h.g;
import cn.thinkingdata.analytics.h.l;
import cn.thinkingdata.analytics.h.q;
import cn.thinkingdata.core.utils.TDLog;
import java.util.Iterator;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
class b extends ThinkingAnalyticsSDK {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final JSONObject f69a;
    private boolean b;

    class a implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ JSONObject f70a;

        a(JSONObject jSONObject) {
            this.f70a = jSONObject;
        }

        @Override // java.lang.Runnable
        public void run() {
            try {
                JSONObject jSONObject = this.f70a;
                if (jSONObject != null && g.a(jSONObject)) {
                    q.a(this.f70a, b.this.f69a, b.this.mConfig.getDefaultTimeZone());
                }
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    /* JADX INFO: renamed from: cn.thinkingdata.analytics.b$b, reason: collision with other inner class name */
    class RunnableC0013b implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ String f71a;

        RunnableC0013b(String str) {
            this.f71a = str;
        }

        @Override // java.lang.Runnable
        public void run() {
            try {
                if (this.f71a == null) {
                    return;
                }
                synchronized (b.this.f69a) {
                    b.this.f69a.remove(this.f71a);
                }
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
    }

    class c implements Runnable {
        c() {
        }

        @Override // java.lang.Runnable
        public void run() {
            synchronized (b.this.f69a) {
                Iterator<String> itKeys = b.this.f69a.keys();
                while (itKeys.hasNext()) {
                    itKeys.next();
                    itKeys.remove();
                }
            }
        }
    }

    class d implements Runnable {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ ThinkingAnalyticsSDK.TATrackStatus f73a;

        d(ThinkingAnalyticsSDK.TATrackStatus tATrackStatus) {
            this.f73a = tATrackStatus;
        }

        @Override // java.lang.Runnable
        public void run() {
            int i = e.f74a[this.f73a.ordinal()];
            if (i == 1) {
                b bVar = b.this;
                bVar.mMessages.a(bVar.getToken(), false);
                b.this.enableTracking(false);
                return;
            }
            if (i == 2) {
                b.this.b = true;
                b bVar2 = b.this;
                bVar2.mMessages.a(bVar2.getToken(), false);
                b.this.optOutTracking();
                return;
            }
            if (i == 3) {
                b.this.b = true;
                b bVar3 = b.this;
                bVar3.mMessages.a(bVar3.getToken(), true);
            } else {
                if (i != 4) {
                    return;
                }
                b.this.b = true;
                b bVar4 = b.this;
                bVar4.mMessages.a(bVar4.getToken(), false);
                b.this.flush();
            }
        }
    }

    static /* synthetic */ class e {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        static final /* synthetic */ int[] f74a;

        static {
            int[] iArr = new int[ThinkingAnalyticsSDK.TATrackStatus.values().length];
            f74a = iArr;
            try {
                iArr[ThinkingAnalyticsSDK.TATrackStatus.PAUSE.ordinal()] = 1;
            } catch (NoSuchFieldError unused) {
            }
            try {
                f74a[ThinkingAnalyticsSDK.TATrackStatus.STOP.ordinal()] = 2;
            } catch (NoSuchFieldError unused2) {
            }
            try {
                f74a[ThinkingAnalyticsSDK.TATrackStatus.SAVE_ONLY.ordinal()] = 3;
            } catch (NoSuchFieldError unused3) {
            }
            try {
                f74a[ThinkingAnalyticsSDK.TATrackStatus.NORMAL.ordinal()] = 4;
            } catch (NoSuchFieldError unused4) {
            }
        }
    }

    b(TDConfig tDConfig) {
        super(tDConfig, true);
        this.f69a = new JSONObject();
        setStatusIdentifyId(getRandomID());
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void clearSuperProperties() {
        if (getStatusHasDisabled()) {
            return;
        }
        cn.thinkingdata.analytics.g.a.a().a(new c());
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void enableAutoTrack(List<ThinkingAnalyticsSDK.AutoTrackEventType> list) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void enableTracking(boolean z) {
        setStatusTrackStatus(z ? ThinkingAnalyticsSDK.TATrackStatus.NORMAL : ThinkingAnalyticsSDK.TATrackStatus.PAUSE);
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public String getDistinctId() {
        String statusIdentifyId = getStatusIdentifyId();
        return statusIdentifyId == null ? getRandomID() : statusIdentifyId;
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    String getLoginId() {
        return getStatusAccountId();
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public JSONObject getSuperProperties() {
        return this.f69a;
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public boolean hasOptOut() {
        return false;
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void identify(String str) {
        if (!q.b(str)) {
            setStatusIdentifyId(str);
            return;
        }
        TDLog.w("ThinkingAnalyticsSDK", "The identity cannot be empty.");
        if (this.mConfig.shouldThrowException()) {
            throw new l("distinct id cannot be empty");
        }
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void ignoreAutoTrackActivities(List<Class<?>> list) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void ignoreAutoTrackActivity(Class<?> cls) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void ignoreView(View view) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void ignoreViewType(Class cls) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public boolean isEnabled() {
        return !getStatusHasDisabled();
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void login(String str) {
        if (getStatusHasDisabled()) {
            return;
        }
        setStatusAccountId(str);
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void logout() {
        if (getStatusHasDisabled()) {
            return;
        }
        setStatusAccountId(null);
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void optInTracking() {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void optOutTracking() {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void optOutTrackingAndDeleteUser() {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void setJsBridge(WebView webView) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void setJsBridgeForX5WebView(Object obj) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void setNetworkType(ThinkingAnalyticsSDK.ThinkingdataNetworkType thinkingdataNetworkType) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void setSuperProperties(JSONObject jSONObject) {
        if (getStatusHasDisabled()) {
            return;
        }
        cn.thinkingdata.analytics.g.a.a().a(new a(jSONObject));
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void setTrackStatus(ThinkingAnalyticsSDK.TATrackStatus tATrackStatus) {
        setStatusTrackStatus(tATrackStatus);
        cn.thinkingdata.analytics.g.a.a().a(new d(tATrackStatus));
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void setViewID(Dialog dialog, String str) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void setViewID(View view, String str) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void setViewProperties(View view, JSONObject jSONObject) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void trackFragmentAppViewScreen() {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void trackViewScreen(Activity activity) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void trackViewScreen(Fragment fragment) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void trackViewScreen(Object obj) {
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK
    public void unsetSuperProperty(String str) {
        if (getStatusHasDisabled()) {
            return;
        }
        cn.thinkingdata.analytics.g.a.a().a(new RunnableC0013b(str));
    }
}
