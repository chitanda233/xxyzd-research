package com.kwad.components.ad.splashscreen;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.SystemClock;
import android.text.TextUtils;
import com.kwad.components.ad.splashscreen.monitor.SplashMonitorInfo;
import com.kwad.components.core.video.k;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.aq;
import com.kwad.sdk.utils.l;
import java.io.File;
import java.io.Serializable;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class SplashPreloadManager {
    private HashMap<String, PreLoadItem> GB;
    private List<String> GC;
    private volatile SharedPreferences GD;
    private final Object mLock;

    public static class PreLoadItem extends com.kwad.sdk.core.response.a.a implements Serializable {
        public long cacheTime;
        public long expiredTime;
        public int materialType;
        public String preloadId;
    }

    /* synthetic */ SplashPreloadManager(byte b) {
        this();
    }

    static class a {
        private static final SplashPreloadManager GE = new SplashPreloadManager(0);
    }

    private void init() {
        Context context = ServiceProvider.getContext();
        if (context != null) {
            this.GD = context.getSharedPreferences("ksadsdk_splash_preload_id_list", 0);
            initData();
        }
    }

    private SplashPreloadManager() {
        this.mLock = new Object();
        this.GB = new HashMap<>();
        this.GC = new ArrayList();
        init();
    }

    private void initData() {
        Map<String, ?> all = this.GD.getAll();
        ArrayList arrayList = new ArrayList();
        for (String str : all.keySet()) {
            PreLoadItem preLoadItem = new PreLoadItem();
            try {
                Object obj = all.get(str);
                if (obj instanceof String) {
                    String str2 = (String) obj;
                    if (TextUtils.isEmpty(str2)) {
                        continue;
                    } else {
                        preLoadItem.parseJson(new JSONObject(str2));
                        if (TextUtils.isEmpty(preLoadItem.preloadId)) {
                            continue;
                        } else {
                            File fileCM = com.kwad.sdk.core.diskcache.b.a.LI().cM(preLoadItem.preloadId);
                            if (fileCM != null && fileCM.exists()) {
                                synchronized (this.mLock) {
                                    try {
                                        this.GB.put(str, preLoadItem);
                                        if (!this.GC.contains(str)) {
                                            this.GC.add(str);
                                        }
                                    } catch (Throwable th) {
                                        throw th;
                                    }
                                }
                            } else {
                                arrayList.add(preLoadItem.preloadId);
                                com.kwad.sdk.core.d.c.d("PreloadManager", "Remove null file list " + preLoadItem.preloadId);
                            }
                        }
                    }
                } else {
                    continue;
                }
            } catch (Exception e) {
                com.kwad.sdk.core.d.c.printStackTrace(e);
            }
        }
        SharedPreferences.Editor editorEdit = this.GD.edit();
        Iterator it = arrayList.iterator();
        while (it.hasNext()) {
            editorEdit.remove((String) it.next());
        }
        editorEdit.apply();
    }

    public final void a(long j, int i) {
        int i2;
        int i3;
        int i4;
        int size;
        boolean z;
        char c;
        long jCurrentTimeMillis = System.currentTimeMillis();
        int size2 = this.GC.size();
        synchronized (this.mLock) {
            ArrayList<String> arrayList = new ArrayList();
            i3 = 0;
            i4 = 0;
            for (String str : this.GB.keySet()) {
                PreLoadItem preLoadItem = this.GB.get(str);
                if (preLoadItem != null && preLoadItem.expiredTime < jCurrentTimeMillis) {
                    arrayList.add(str);
                    if (preLoadItem.materialType == 2) {
                        i3++;
                    } else if (preLoadItem.materialType == 1) {
                        i4++;
                    }
                }
            }
            SharedPreferences.Editor editorEdit = this.GD.edit();
            for (String str2 : arrayList) {
                this.GC.remove(str2);
                this.GB.remove(str2);
                editorEdit.remove(str2);
                com.kwad.sdk.core.diskcache.b.a.LI().remove(str2);
            }
            editorEdit.apply();
            size = this.GC.size();
        }
        if (size > 30) {
            com.kwad.sdk.core.d.c.d("PreloadManager", "大于 30 按失效日期远近顺序移除");
            int i5 = size - 15;
            for (i2 = 0; i2 < i5; i2++) {
                String str3 = "";
                synchronized (this.mLock) {
                    long j2 = Long.MAX_VALUE;
                    for (PreLoadItem preLoadItem2 : this.GB.values()) {
                        if (preLoadItem2.expiredTime < j2) {
                            long j3 = preLoadItem2.expiredTime;
                            str3 = preLoadItem2.preloadId;
                            j2 = j3;
                        }
                    }
                    if (TextUtils.isEmpty(str3)) {
                        z = true;
                        c = 2;
                    } else {
                        PreLoadItem preLoadItem3 = this.GB.get(str3);
                        if (preLoadItem3 != null) {
                            c = 2;
                            if (preLoadItem3.materialType == 2) {
                                i3++;
                                z = true;
                            } else {
                                z = true;
                                if (preLoadItem3.materialType == 1) {
                                    i4++;
                                }
                            }
                        } else {
                            z = true;
                            c = 2;
                        }
                        this.GC.remove(str3);
                        this.GB.remove(str3);
                        this.GD.edit().remove(str3).apply();
                        com.kwad.sdk.core.d.c.d("PreloadManager", "移除 preloadId = " + str3 + " expiredTime =  " + j2);
                    }
                }
                if (!TextUtils.isEmpty(str3)) {
                    com.kwad.sdk.core.diskcache.b.a.LI().remove(str3);
                }
            }
        }
        int i6 = i3;
        List<String> listLY = lY();
        int size3 = size2 - listLY.size();
        List<Integer> listI = i(listLY);
        com.kwad.components.ad.splashscreen.monitor.b.mt();
        com.kwad.components.ad.splashscreen.monitor.b.a(j, listLY, listI, i, size3, i4, i6);
    }

    public static SplashPreloadManager lX() {
        SplashPreloadManager splashPreloadManager = a.GE;
        if (splashPreloadManager.GD == null) {
            splashPreloadManager.init();
        }
        return splashPreloadManager;
    }

    public final int a(AdResultData adResultData, boolean z, int i) {
        Iterator<AdInfo> it;
        String strM;
        boolean zA;
        com.kwad.components.ad.splashscreen.monitor.b.mt();
        com.kwad.components.ad.splashscreen.monitor.b.k(adResultData);
        int i2 = 0;
        for (AdTemplate adTemplate : adResultData.getAdTemplateList()) {
            if (adTemplate != null) {
                Iterator<AdInfo> it2 = adTemplate.adInfoList.iterator();
                while (it2.hasNext()) {
                    AdInfo next = it2.next();
                    if (next.adPreloadInfo != null && this.GD != null) {
                        long jElapsedRealtime = SystemClock.elapsedRealtime();
                        if (!r(next)) {
                            if (com.kwad.sdk.core.response.helper.a.bi(next)) {
                                strM = com.kwad.sdk.core.response.helper.a.M(next);
                            } else {
                                strM = com.kwad.sdk.core.response.helper.a.bj(next) ? com.kwad.sdk.core.response.helper.a.ba(next).materialUrl : null;
                            }
                            if (!TextUtils.isEmpty(strM)) {
                                String strBf = com.kwad.sdk.core.response.helper.a.bf(next);
                                if (next.adPreloadInfo.preloadType != 1 || aq.isWifiConnected(ServiceProvider.getContext()) || z) {
                                    com.kwad.sdk.core.d.c.d("PreloadManager", "start Download preloadId " + strBf + " true url " + strM);
                                    it = it2;
                                    a(adResultData.getPosId(), 1);
                                    com.kwad.sdk.core.network.a.a.C0515a c0515a = new com.kwad.sdk.core.network.a.a.C0515a();
                                    if (q(next)) {
                                        zA = KSImageLoader.loadImageSync(strM) != null;
                                    } else {
                                        zA = k.a(strM, strBf, c0515a);
                                    }
                                    if (zA) {
                                        p(next);
                                        i2++;
                                        com.kwad.components.ad.splashscreen.monitor.b.mt();
                                        com.kwad.components.ad.splashscreen.monitor.b.a(adTemplate, SystemClock.elapsedRealtime() - jElapsedRealtime, 1, i);
                                    } else {
                                        com.kwad.components.ad.splashscreen.monitor.b.mt();
                                        com.kwad.components.ad.splashscreen.monitor.b.d(adTemplate, 4, c0515a.msg);
                                        com.kwad.components.core.p.a.vX().g(adTemplate, 1, c0515a.msg);
                                    }
                                } else {
                                    it = it2;
                                    com.kwad.components.ad.splashscreen.monitor.b.mt();
                                    com.kwad.components.ad.splashscreen.monitor.b.d(adTemplate, 1, SplashMonitorInfo.ERROR_NET_MSG);
                                }
                            } else {
                                it = it2;
                                com.kwad.components.ad.splashscreen.monitor.b.mt();
                                com.kwad.components.ad.splashscreen.monitor.b.d(adTemplate, 2, SplashMonitorInfo.ERROR_URL_INVALID_MSG);
                            }
                        } else {
                            it = it2;
                            com.kwad.components.ad.splashscreen.monitor.b.mt();
                            com.kwad.components.ad.splashscreen.monitor.b.a(adTemplate, SystemClock.elapsedRealtime() - jElapsedRealtime, 2, i);
                            p(next);
                            i2++;
                        }
                    } else {
                        it = it2;
                        com.kwad.components.ad.splashscreen.monitor.b.mt();
                        com.kwad.components.ad.splashscreen.monitor.b.d(adTemplate, 3, SplashMonitorInfo.ERROR_PRELOAD_ID_INVALID_MSG);
                    }
                    it2 = it;
                }
            }
        }
        AdTemplate adTemplate2 = adResultData.getAdTemplateList().size() > 0 ? adResultData.getAdTemplateList().get(0) : null;
        if (i2 > 0) {
            l.as("splashAd_", "onSplashVideoAdCacheSuccess");
            com.kwad.components.core.p.a.vX().h(adTemplate2, i2);
        } else {
            l.as("splashAd_", "onSplashVideoAdCacheFailed");
        }
        return i2;
    }

    private void p(AdInfo adInfo) {
        PreLoadItem preLoadItem = new PreLoadItem();
        preLoadItem.cacheTime = System.currentTimeMillis();
        preLoadItem.expiredTime = System.currentTimeMillis() + (((long) adInfo.adPreloadInfo.validityPeriod) * 1000);
        preLoadItem.preloadId = com.kwad.sdk.core.response.helper.a.bf(adInfo);
        preLoadItem.materialType = com.kwad.sdk.core.response.helper.a.bi(adInfo) ? 2 : 1;
        synchronized (this.mLock) {
            this.GB.put(adInfo.adPreloadInfo.preloadId, preLoadItem);
            if (!this.GC.contains(adInfo.adPreloadInfo.preloadId)) {
                this.GC.add(adInfo.adPreloadInfo.preloadId);
            }
        }
        if (this.GD != null) {
            SharedPreferences.Editor editorEdit = this.GD.edit();
            editorEdit.putString(adInfo.adPreloadInfo.preloadId, preLoadItem.toJson().toString());
            editorEdit.apply();
        }
    }

    public final boolean h(AdResultData adResultData) {
        if (!adResultData.getAdTemplateList().isEmpty()) {
            AdTemplate adTemplate = adResultData.getAdTemplateList().get(0);
            if (!adTemplate.adInfoList.isEmpty()) {
                AdInfo adInfo = adTemplate.adInfoList.get(0);
                if (adInfo.adPreloadInfo != null) {
                    if (q(adInfo)) {
                        return KSImageLoader.isImageExist(com.kwad.sdk.core.response.helper.a.ba(adInfo).materialUrl);
                    }
                    return r(adInfo);
                }
            }
        }
        return false;
    }

    private static boolean q(AdInfo adInfo) {
        return com.kwad.sdk.core.config.e.a(com.kwad.components.ad.splashscreen.b.a.Hf) && com.kwad.sdk.core.response.helper.a.bj(adInfo);
    }

    public static boolean i(AdResultData adResultData) {
        if (!adResultData.getAdTemplateList().isEmpty()) {
            AdTemplate adTemplate = adResultData.getAdTemplateList().get(0);
            if (!adTemplate.adInfoList.isEmpty()) {
                return com.kwad.sdk.core.response.helper.a.bj(adTemplate.adInfoList.get(0));
            }
        }
        return false;
    }

    public static boolean j(AdResultData adResultData) {
        if (!adResultData.getAdTemplateList().isEmpty()) {
            AdTemplate adTemplate = adResultData.getAdTemplateList().get(0);
            if (!adTemplate.adInfoList.isEmpty()) {
                return com.kwad.sdk.core.response.helper.a.bi(adTemplate.adInfoList.get(0));
            }
        }
        return false;
    }

    private boolean r(AdInfo adInfo) {
        if (q(adInfo)) {
            return KSImageLoader.isImageExist(com.kwad.sdk.core.response.helper.a.ba(adInfo).materialUrl);
        }
        String str = adInfo.adPreloadInfo.preloadId;
        if (str != null) {
            File fileCM = com.kwad.sdk.core.diskcache.b.a.LI().cM(str);
            com.kwad.sdk.core.d.c.d("PreloadManager", "check preloadId " + str + " file exists " + (fileCM == null ? "null" : Boolean.valueOf(fileCM.exists())));
            if (fileCM != null && fileCM.exists()) {
                return true;
            }
        }
        return false;
    }

    public static File ac(String str) {
        if (str == null) {
            return null;
        }
        com.kwad.sdk.core.d.c.d("PreloadManager", "getVideoFile preloadId " + str + "  url " + str);
        File fileCM = com.kwad.sdk.core.diskcache.b.a.LI().cM(str);
        if (fileCM == null || !fileCM.exists()) {
            return null;
        }
        return fileCM;
    }

    public final List<String> W() {
        ArrayList arrayList = new ArrayList();
        synchronized (this.mLock) {
            com.kwad.sdk.core.d.c.d("PreloadManager", "getPreloadIdList start ");
            for (int i = 0; i < this.GC.size(); i++) {
                String str = this.GC.get(i);
                File fileCM = com.kwad.sdk.core.diskcache.b.a.LI().cM(str);
                if (fileCM != null && fileCM.exists()) {
                    arrayList.add(str);
                }
            }
            com.kwad.sdk.core.d.c.d("PreloadManager", "getPreloadIdList end ");
        }
        com.kwad.sdk.core.d.c.d("PreloadManager", "getPreloadIdList " + this.GC.size());
        return arrayList;
    }

    public final List<String> lY() {
        ArrayList arrayList;
        synchronized (this.mLock) {
            com.kwad.sdk.core.d.c.d("PreloadManager", "getPreloadIdListWithoutClean start ");
            arrayList = new ArrayList(this.GC);
            com.kwad.sdk.core.d.c.d("PreloadManager", "getPreloadIdListWithoutClean end ");
        }
        com.kwad.sdk.core.d.c.d("PreloadManager", "getPreloadIdListWithoutClean " + this.GC.size());
        return arrayList;
    }

    public final List<Integer> i(List<String> list) {
        PreLoadItem preLoadItem;
        ArrayList arrayList = new ArrayList();
        if (list == null || list.isEmpty()) {
            return arrayList;
        }
        synchronized (this.mLock) {
            com.kwad.sdk.core.d.c.d("PreloadManager", "getMaterialTypeList start ");
            for (int i = 0; i < list.size(); i++) {
                String str = list.get(i);
                if (this.GB.containsKey(str) && (preLoadItem = this.GB.get(str)) != null) {
                    arrayList.add(Integer.valueOf(preLoadItem.materialType));
                }
            }
            com.kwad.sdk.core.d.c.d("PreloadManager", "getMaterialTypeList end ");
        }
        com.kwad.sdk.core.d.c.d("PreloadManager", "getMaterialTypeList " + arrayList.size());
        return arrayList;
    }
}
