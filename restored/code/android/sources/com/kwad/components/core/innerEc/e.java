package com.kwad.components.core.innerEc;

import android.app.Activity;
import android.content.Context;
import android.text.TextUtils;
import com.kwad.components.core.innerEc.a.k;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.components.offline.api.adInnerEc.login.IAdInnerEcLoginBindListener;
import com.kwad.components.offline.api.adInnerEc.login.InnerEcLoginResponse;
import com.kwad.components.offline.api.core.adInnerEc.IAdInnerEcExternalModule;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ai;
import com.kwad.sdk.utils.bz;
import java.util.concurrent.atomic.AtomicBoolean;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class e {
    private static volatile e SL;
    private static final AtomicBoolean SN = new AtomicBoolean(false);
    private static final AtomicBoolean SO = new AtomicBoolean(false);
    private static final AtomicBoolean SP = new AtomicBoolean(false);
    private IAdInnerEcExternalModule SM;
    private final String TAG = "InnerEcLoginManager";
    private InnerEcUserLoginBindInfo SQ = new InnerEcUserLoginBindInfo();

    public final long getUserId() {
        return this.SQ.userId;
    }

    public final String getServiceToken() {
        return this.SQ.serviceToken;
    }

    private long getExpire() {
        return this.SQ.expire;
    }

    public final String getSid() {
        return this.SQ.sid;
    }

    public final String rd() {
        return this.SQ.userName;
    }

    public static e re() {
        if (SL == null) {
            synchronized (e.class) {
                if (SL == null) {
                    SL = new e();
                }
            }
        }
        if (!SN.get()) {
            SL.init();
        }
        return SL;
    }

    public static boolean isReady() {
        return SN.get();
    }

    private void init() {
        AtomicBoolean atomicBoolean = SN;
        if (atomicBoolean.get() || SP.get()) {
            return;
        }
        AtomicBoolean atomicBoolean2 = SO;
        if (!atomicBoolean2.get()) {
            if (bz.aD(((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getApiVersion(), "4.10.30")) {
                try {
                    com.kwad.sdk.service.c.putComponentProxy(Class.forName("com.kwad.auth.login.KwadRouteHandlerActivity"), RouteHandlerActivityProxy.class);
                } catch (Throwable unused) {
                    SP.set(true);
                    return;
                }
            } else {
                try {
                    com.kwad.sdk.service.c.putComponentProxy(Class.forName("com.kwai.auth.login.kwailogin.applogin.RouteHandlerActivity"), RouteHandlerActivityProxy.class);
                } catch (Throwable unused2) {
                    SP.set(true);
                    return;
                }
            }
            atomicBoolean2.set(true);
        }
        com.kwad.components.core.offline.a.a.a aVar = (com.kwad.components.core.offline.a.a.a) com.kwad.sdk.components.d.f(com.kwad.components.core.offline.a.a.a.class);
        if (aVar == null || !aVar.tD()) {
            return;
        }
        Context context = ServiceProvider.getContext();
        com.kwad.sdk.core.d.c.w("InnerEcLoginManager", "getApp: " + context);
        context.getApplicationContext();
        IAdInnerEcExternalModule iAdInnerEcExternalModuleTE = aVar.tE();
        this.SM = iAdInnerEcExternalModuleTE;
        if (iAdInnerEcExternalModuleTE != null) {
            atomicBoolean.set(true);
            rg();
        }
    }

    public final void a(Activity activity, IAdInnerEcLoginBindListener iAdInnerEcLoginBindListener, String str) {
        com.kwad.sdk.core.d.c.i("InnerEcLoginManager", "click start");
        if (!SN.get()) {
            iAdInnerEcLoginBindListener.onFailed(-1, "adInnerEcExternalModule is null", 2);
            return;
        }
        IAdInnerEcExternalModule iAdInnerEcExternalModule = this.SM;
        if (iAdInnerEcExternalModule == null) {
            iAdInnerEcLoginBindListener.onFailed(-1, "adInnerEcExternalModule is null", 2);
        } else {
            iAdInnerEcExternalModule.startLoginAuth(activity, iAdInnerEcLoginBindListener, str);
        }
    }

    public static void a(Context context, AdTemplate adTemplate, k kVar) {
        if (!SN.get()) {
            kVar.k(2002, "not login");
            return;
        }
        String strLc = com.kwad.sdk.core.config.e.Lc();
        if (TextUtils.isEmpty(strLc)) {
            kVar.k(2003, "getClosureH5AuthUrl is null");
        } else {
            AdWebViewActivityProxy.launch(context, new AdWebViewActivityProxy.a.C0449a().aX(com.kwad.sdk.core.response.helper.b.dh(adTemplate)).aY(strLc).aU(adTemplate).bl(3).b(kVar).um());
        }
    }

    public static void b(String str, c cVar, String str2) {
        new d().a(str, cVar, str2);
    }

    public final void b(InnerEcUserLoginBindInfo innerEcUserLoginBindInfo) {
        if (innerEcUserLoginBindInfo != null) {
            this.SQ = innerEcUserLoginBindInfo;
            ai.c(ServiceProvider.getContext(), innerEcUserLoginBindInfo.toJson().toString(), false);
        }
    }

    public final boolean rf() {
        if (SN.get() && !ai.Vo()) {
            return (!ai.Vn() || rg()) && getExpire() > 0 && !TextUtils.isEmpty(getServiceToken()) && !TextUtils.isEmpty(getSid()) && getUserId() > 0 && System.currentTimeMillis() < getExpire();
        }
        return false;
    }

    public final void a(InnerEcLoginResponse innerEcLoginResponse, Activity activity) {
        if (!SN.get()) {
            activity.finish();
            return;
        }
        IAdInnerEcExternalModule iAdInnerEcExternalModule = this.SM;
        if (iAdInnerEcExternalModule == null) {
            activity.finish();
        } else {
            iAdInnerEcExternalModule.handleLoginResponse(innerEcLoginResponse, activity);
        }
    }

    private boolean rg() {
        try {
            String strF = ai.f(ServiceProvider.getContext(), true);
            if (!TextUtils.isEmpty(strF)) {
                InnerEcUserLoginBindInfo innerEcUserLoginBindInfo = new InnerEcUserLoginBindInfo();
                innerEcUserLoginBindInfo.parseJson(new JSONObject(strF));
                this.SQ = innerEcUserLoginBindInfo;
            }
            return true;
        } catch (Exception e) {
            com.kwad.sdk.core.d.c.printStackTrace(e);
            return false;
        }
    }
}
