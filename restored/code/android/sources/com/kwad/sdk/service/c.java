package com.kwad.sdk.service;

import com.ksad.annotation.invoker.ForInvoker;
import com.kwad.components.ad.feed.FeedDownloadActivityProxy;
import com.kwad.components.ad.fullscreen.KsFullScreenLandScapeVideoActivityProxy;
import com.kwad.components.ad.fullscreen.KsFullScreenVideoActivityProxy;
import com.kwad.components.ad.reward.KSRewardLandScapeVideoActivityProxy;
import com.kwad.components.ad.reward.KSRewardVideoActivityProxy;
import com.kwad.components.core.internal.api.KSAdVideoPlayConfigImpl;
import com.kwad.components.core.internal.api.VideoPlayConfigImpl;
import com.kwad.components.core.page.AdWebViewActivityProxy;
import com.kwad.components.core.page.AdWebViewVideoActivityProxy;
import com.kwad.components.core.page.g;
import com.kwad.framework.filedownloader.services.FileDownloadServiceProxy;
import com.kwad.sdk.internal.api.SceneImpl;
import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class c {
    private static final Map<Class<?>, Class<?>> bnU = new HashMap(128);
    private static final Map<Class<?>, Class<?>> bnV = new HashMap();
    private static boolean bnW = false;
    private static boolean bnX = false;

    public static void init() {
        Uh();
        Uj();
    }

    private static synchronized void Uh() {
        if (bnW) {
            return;
        }
        Ui();
        bnW = true;
    }

    @ForInvoker(methodId = "initComponentProxyForInvoker")
    private static void Ui() {
        FeedDownloadActivityProxy.register();
        KsFullScreenLandScapeVideoActivityProxy.register();
        KsFullScreenVideoActivityProxy.register();
        KSRewardLandScapeVideoActivityProxy.register();
        KSRewardVideoActivityProxy.register();
        com.kwad.components.core.page.a.register();
        AdWebViewActivityProxy.register();
        AdWebViewVideoActivityProxy.register();
        g.register();
        com.kwad.components.core.s.a.a.register();
        FileDownloadServiceProxy.register();
        com.kwad.sdk.collector.b.a.register();
        a.register();
    }

    public static void putComponentProxy(Class<?> cls, Class<?> cls2) {
        bnU.put(cls, cls2);
    }

    public static Class<?> g(Class<?> cls) {
        Uh();
        return bnU.get(cls);
    }

    private static synchronized void Uj() {
        if (bnX) {
            return;
        }
        Uk();
        bnX = true;
    }

    @ForInvoker(methodId = "initModeImplForInvoker")
    private static void Uk() {
        com.kwad.components.ad.reward.retryReward.a.register();
        KSAdVideoPlayConfigImpl.register();
        com.kwad.components.core.internal.api.d.register();
        VideoPlayConfigImpl.register();
        com.kwad.components.core.q.b.register();
        SceneImpl.register();
    }

    public static void a(Class cls, Class cls2) {
        bnV.put(cls, cls2);
    }

    public static Class<?> h(Class<?> cls) {
        Uj();
        return bnV.get(cls);
    }
}
