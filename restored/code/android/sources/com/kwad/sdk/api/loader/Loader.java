package com.kwad.sdk.api.loader;

import android.content.Context;
import android.content.res.Resources;
import android.text.TextUtils;
import com.kwad.components.offline.api.BuildConfig;
import com.kwad.sdk.api.KsAdSDK;
import com.kwad.sdk.api.SdkConfig;
import com.kwad.sdk.api.core.IKsAdSDK;
import com.kwad.sdk.api.core.KSLifecycleObserver;
import com.kwad.sdk.api.core.KsAdSdkDynamicApi;
import com.kwad.sdk.api.proxy.IComponentProxy;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public class Loader {
    static final /* synthetic */ boolean $assertionsDisabled = false;
    private static Context mContext;
    private IKsAdSDK aIC;
    private m aID;
    private final AtomicBoolean mHasInit;

    /* synthetic */ Loader(byte b) {
        this();
    }

    static class a {
        private static final Loader aIE = new Loader(0);
    }

    public static Loader get() {
        return a.aIE;
    }

    private Loader() {
        this.aID = null;
        this.mHasInit = new AtomicBoolean(false);
    }

    public IKsAdSDK init(Context context, ClassLoader classLoader) {
        if (this.mHasInit.get()) {
            return this.aIC;
        }
        mContext = context.getApplicationContext();
        bt(context);
        if (bs(context)) {
            this.aID = m.a(context, classLoader, i.bn(context));
        }
        boolean zBooleanValue = com.kwad.sdk.api.a.aHB.booleanValue();
        m mVar = this.aID;
        if (mVar == null && zBooleanValue) {
            ClassLoader classLoaderInitDex = DexLoader.initDex(context, classLoader);
            if (classLoaderInitDex == null) {
                return null;
            }
            new StringBuilder("IKsAdSDK after dexClassLoader: ").append(classLoaderInitDex);
            this.aIC = a(classLoaderInitDex);
            new StringBuilder("IKsAdSDK after mSDKImpl: ").append(this.aIC);
        } else if (mVar == null) {
            IKsAdSDK iKsAdSDKA = a(getClass().getClassLoader());
            this.aIC = iKsAdSDKA;
            iKsAdSDKA.setIsExternal(false);
        } else {
            IKsAdSDK iKsAdSDKHR = mVar.HR();
            this.aIC = iKsAdSDKHR;
            iKsAdSDKHR.setIsExternal(true);
        }
        com.kwad.sdk.api.c.a(this.aIC);
        if (this.aID != null) {
            HU();
        }
        this.mHasInit.set(true);
        return this.aIC;
    }

    public void rest() {
        this.mHasInit.set(false);
        mContext = null;
        this.aIC = null;
        this.aID = null;
    }

    private static void HU() {
        try {
            int iHI = com.kwad.sdk.api.c.HI();
            if (iHI > 0) {
                try {
                    f.bm(mContext).setDefaultUncaughtExceptionHandler(Thread.getDefaultUncaughtExceptionHandler());
                    Thread.setDefaultUncaughtExceptionHandler(f.bm(mContext));
                    f.bm(mContext).de(iHI);
                } catch (Throwable th) {
                    th.printStackTrace();
                }
            }
        } catch (Throwable th2) {
            th2.printStackTrace();
        }
    }

    private boolean bs(Context context) {
        try {
            String strBn = i.bn(context);
            String strBo = i.bo(context);
            if (TextUtils.isEmpty(strBn) && TextUtils.isEmpty(strBo)) {
                return false;
            }
            if (!TextUtils.isEmpty(strBo) && i.M(strBo, strBn)) {
                i.s(context, strBo);
                C(context, strBn);
                i.t(context, "");
                strBn = strBo;
            }
            return !TextUtils.isEmpty(strBn);
        } catch (Throwable th) {
            com.kwad.sdk.api.c.t(th);
            return false;
        }
    }

    private static void C(Context context, String str) {
        j.B(context, str);
    }

    private static void bt(Context context) {
        try {
            String strBp = i.bp(context);
            boolean zB = b.b(context, i.aIh, false);
            if (TextUtils.isEmpty(strBp) || !strBp.equals(BuildConfig.VERSION_NAME) || zB) {
                String strBn = i.bn(context);
                i.s(context, "");
                i.t(context, "");
                b.a(context, i.aIh, false);
                j.j(j.x(context, strBn));
                i.u(context, BuildConfig.VERSION_NAME);
            }
        } catch (Throwable th) {
            com.kwad.sdk.api.c.t(th);
        }
    }

    public boolean isExternalLoaded() {
        return this.aID != null;
    }

    public Context getContext() {
        return mContext;
    }

    public ClassLoader getRealClassLoader() {
        m mVar = this.aID;
        if (mVar != null) {
            return mVar.getClassLoader();
        }
        return getClass().getClassLoader();
    }

    public Resources getExternalResource() {
        m mVar = this.aID;
        if (mVar != null) {
            return mVar.HQ();
        }
        return null;
    }

    public ClassLoader getExternalClassLoader() {
        m mVar = this.aID;
        ClassLoader classLoader = mVar != null ? mVar.getClassLoader() : null;
        if (com.kwad.sdk.api.a.aHB.booleanValue()) {
            classLoader = this.aIC.getClass().getClassLoader();
            new StringBuilder("Loader getExternalClassLoader: ").append(classLoader);
        }
        new StringBuilder("Loader result: ").append(classLoader);
        return classLoader;
    }

    static synchronized IKsAdSDK a(ClassLoader classLoader) {
        Object objInvoke;
        try {
            objInvoke = Class.forName(((KsAdSdkDynamicApi) IKsAdSDK.class.getAnnotation(KsAdSdkDynamicApi.class)).value(), true, classLoader).getDeclaredMethod("get", new Class[0]).invoke(null, new Object[0]);
            if (objInvoke == null) {
                throw new RuntimeException("Can not get sdk form " + classLoader);
            }
        } catch (Exception e) {
            throw new RuntimeException(e);
        }
        return (IKsAdSDK) objInvoke;
    }

    public <T extends IComponentProxy> T newComponentProxy(Context context, Class<?> cls, Object obj) {
        checkInitSDK(context);
        return (T) this.aIC.newComponentProxy(cls, obj);
    }

    public <T> T newInstance(Class<T> cls) {
        checkInitSDK(mContext);
        return (T) this.aIC.newInstance(cls);
    }

    public static void checkInitSDK(Context context) {
        if (KsAdSDK.sHasInit.get()) {
            return;
        }
        if (context == null) {
            context = KSLifecycleObserver.getInstance().getApplication();
        }
        if (context == null) {
            context = c.HP();
        }
        KsAdSDK.init(context, SdkConfig.create(b.getString(context, "sdkconfig")));
    }
}
