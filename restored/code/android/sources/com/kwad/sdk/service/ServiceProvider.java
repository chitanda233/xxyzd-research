package com.kwad.sdk.service;

import android.content.Context;
import com.kwad.components.offline.api.BuildConfig;
import com.kwad.sdk.api.SdkConfig;
import com.kwad.sdk.service.a.e;
import com.kwad.sdk.wrapper.m;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.concurrent.CopyOnWriteArrayList;

/* JADX INFO: loaded from: classes3.dex */
public final class ServiceProvider {
    private static List<Throwable> PL;
    private static Context bnY;
    private static Context bnZ;
    private static boolean boa;
    private static Context mContext;

    public static String getSdkVersion() {
        return BuildConfig.VERSION_NAME;
    }

    public static void cI(Context context) {
        bnY = context;
        mContext = m.eP(context);
    }

    public static void Ul() {
        boa = true;
    }

    @Deprecated
    public static Context Um() {
        return mContext;
    }

    public static Context getContext() {
        if (boa) {
            return Um();
        }
        if (bnZ == null) {
            bnZ = m.wrapContextIfNeed(mContext);
        }
        return bnZ;
    }

    public static SdkConfig getSDKConfig() {
        return b.getSDKConfig();
    }

    public static String getAppId() {
        return b.getAppId();
    }

    public static String getAppName() {
        return b.getAppName();
    }

    public static <T> T get(Class<T> cls) {
        return (T) ServiceProviderDelegate.INSTANCE.get(cls);
    }

    public static <T> void put(Class<T> cls, T t) {
        ServiceProviderDelegate.INSTANCE.put(cls, t);
    }

    public static void reportSdkCaughtException(Throwable th) {
        e eVar = (e) get(e.class);
        if (eVar != null) {
            eVar.gatherException(th);
        } else {
            b(th);
        }
    }

    private static void b(Throwable th) {
        if (PL == null) {
            PL = new CopyOnWriteArrayList();
        }
        PL.add(th);
    }

    public static void h(com.kwad.sdk.g.a<Throwable> aVar) {
        List<Throwable> list = PL;
        if (list == null) {
            return;
        }
        Iterator<Throwable> it = list.iterator();
        while (it.hasNext()) {
            aVar.accept(it.next());
        }
        PL.clear();
        PL = null;
    }

    enum ServiceProviderDelegate {
        INSTANCE;

        private final Map<Class<?>, Object> mProviders = new HashMap(32);

        ServiceProviderDelegate() {
        }

        public final <T> T get(Class<T> cls) {
            return (T) this.mProviders.get(cls);
        }

        public final <T> void put(Class<T> cls, T t) {
            this.mProviders.put(cls, t);
        }
    }
}
