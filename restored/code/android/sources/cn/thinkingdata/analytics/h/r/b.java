package cn.thinkingdata.analytics.h.r;

import android.text.TextUtils;
import cn.thinkingdata.analytics.ThinkingAnalyticsSDK;
import cn.thinkingdata.analytics.h.k;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes.dex */
public class b {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final List<cn.thinkingdata.analytics.h.r.a> f130a = new ArrayList();

    class a implements ThinkingAnalyticsSDK.n {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        final /* synthetic */ cn.thinkingdata.analytics.h.r.a f131a;

        a(cn.thinkingdata.analytics.h.r.a aVar) {
            this.f131a = aVar;
        }

        @Override // cn.thinkingdata.analytics.ThinkingAnalyticsSDK.n
        public void a(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
            b.b(this.f131a, thinkingAnalyticsSDK);
            thinkingAnalyticsSDK.flush();
        }
    }

    public static void a(ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
        Iterator<cn.thinkingdata.analytics.h.r.a> it = f130a.iterator();
        while (it.hasNext()) {
            b(it.next(), thinkingAnalyticsSDK);
        }
        thinkingAnalyticsSDK.flush();
    }

    public static void a(cn.thinkingdata.analytics.h.r.a aVar) {
        if (aVar == null) {
            return;
        }
        ThinkingAnalyticsSDK.allInstances(new a(aVar));
        f130a.add(aVar);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void b(cn.thinkingdata.analytics.h.r.a aVar, ThinkingAnalyticsSDK thinkingAnalyticsSDK) {
        int i = aVar.e;
        boolean z = true;
        if (i != 1 ? i < 2 || (!TextUtils.isEmpty(aVar.d) && !TextUtils.equals(thinkingAnalyticsSDK.mConfig.mToken, aVar.d)) : !thinkingAnalyticsSDK.mConfig.mEnableAutoPush) {
            z = false;
        }
        if (z) {
            k kVar = aVar.f129a;
            if (kVar != k.TRACK) {
                if (kVar == k.USER_SET) {
                    thinkingAnalyticsSDK.user_set(aVar.c);
                    return;
                }
                return;
            }
            int i2 = aVar.f;
            if (i2 == 0) {
                thinkingAnalyticsSDK.autoTrack(aVar.b, aVar.c);
            } else if (i2 == 2) {
                thinkingAnalyticsSDK.trackWithDebugOnly(aVar.b, aVar.c);
            }
        }
    }
}
