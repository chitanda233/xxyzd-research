package com.kwad.sdk.ip.direct;

import android.os.Handler;
import android.os.HandlerThread;
import android.os.Message;
import android.text.TextUtils;
import com.kwad.sdk.core.NetworkMonitor;
import com.kwad.sdk.core.response.model.HttpDnsInfo;
import com.kwad.sdk.i;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.f;
import com.kwad.sdk.service.a.h;
import java.util.Iterator;
import java.util.List;
import java.util.Random;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.PriorityBlockingQueue;
import java.util.concurrent.atomic.AtomicInteger;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private static int bgL = -1;
    private static volatile boolean bgM;
    private static c bgU;
    private static HandlerThread bgV;
    private static Handler bgW;
    private static List<HttpDnsInfo.IpInfo> bgN = new CopyOnWriteArrayList();
    private static List<HttpDnsInfo.IpInfo> bgO = new CopyOnWriteArrayList();
    private static List<HttpDnsInfo.IpInfo> bgP = new CopyOnWriteArrayList();
    private static List<c> bgQ = new CopyOnWriteArrayList();
    private static List<c> bgR = new CopyOnWriteArrayList();
    private static PriorityBlockingQueue<c> bgS = new PriorityBlockingQueue<>();
    private static AtomicInteger bgT = new AtomicInteger(0);
    private static volatile boolean bgX = false;
    private static float bgY = -1.0f;
    private static float bgZ = -1.0f;
    private static float bha = -1.0f;
    private static int bhb = 0;
    private static volatile boolean bhc = false;
    private static volatile boolean bhd = false;
    private static NetworkMonitor.a bhe = new NetworkMonitor.a() { // from class: com.kwad.sdk.ip.direct.a.1
        @Override // com.kwad.sdk.core.NetworkMonitor.a
        public final void a(NetworkMonitor.NetworkState networkState) {
            com.kwad.sdk.core.d.c.d("IpDirect_Helper", "*********onNetworkChange");
            if (a.bhd) {
                a.access$102(true);
                com.kwad.sdk.core.d.c.d("IpDirect_Helper", "*********onNetworkChange sHasNetChanged true");
            } else {
                a.access$002(true);
            }
        }
    };
    private static Runnable bhf = new Runnable() { // from class: com.kwad.sdk.ip.direct.a.3
        @Override // java.lang.Runnable
        public final void run() {
            a.Rt();
        }
    };

    static /* synthetic */ boolean access$002(boolean z) {
        bhd = true;
        return true;
    }

    static /* synthetic */ boolean access$102(boolean z) {
        bhc = true;
        return true;
    }

    private static void init() {
        if (bgV != null) {
            return;
        }
        HandlerThread handlerThread = new HandlerThread("IpDirectHelper");
        bgV = handlerThread;
        handlerThread.start();
        bgW = new Handler(bgV.getLooper()) { // from class: com.kwad.sdk.ip.direct.a.2
            @Override // android.os.Handler
            public final void handleMessage(Message message) {
                int i = message.what;
                if (i == 1) {
                    a.Rt();
                    a.Ru();
                } else {
                    if (i != 2) {
                        return;
                    }
                    a.RC();
                }
            }
        };
        f fVar = (f) ServiceProvider.get(f.class);
        if (fVar != null) {
            NetworkMonitor.getInstance().a(fVar.getContext(), bhe);
        }
    }

    private static void Ro() {
        Handler handler;
        if (bgX || (handler = bgW) == null) {
            return;
        }
        handler.obtainMessage(1).sendToTarget();
    }

    public static String Rp() {
        c cVar = bgU;
        return cVar != null ? cVar.getIp() : "";
    }

    public static float Rq() {
        return bgY;
    }

    public static float Rr() {
        return bgZ;
    }

    public static float Rs() {
        return bha;
    }

    public static void a(HttpDnsInfo httpDnsInfo) {
        if (httpDnsInfo == null) {
            return;
        }
        h hVar = (h) ServiceProvider.get(h.class);
        if (hVar == null) {
            com.kwad.sdk.core.d.c.w("IpDirect_Helper", "sdkConfigProvider == null");
            return;
        }
        boolean zGc = hVar.Gc();
        bgM = zGc;
        com.kwad.sdk.core.d.c.d("IpDirect_Helper", "isEnable:" + zGc);
        if (zGc) {
            com.kwad.sdk.core.d.c.d("IpDirect_Helper", httpDnsInfo.toString());
            bgN = httpDnsInfo.recommendList;
            bgO = httpDnsInfo.backUpList;
            bgP = httpDnsInfo.otherList;
            if (bgN.isEmpty() && bgO.isEmpty() && bgP.isEmpty()) {
                com.kwad.sdk.core.d.c.w("IpDirect_Helper", "HttpDnsInfo is empty");
            } else {
                init();
                Ro();
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void Rt() {
        Ry();
        List<HttpDnsInfo.IpInfo> list = bgN;
        List<HttpDnsInfo.IpInfo> list2 = bgO;
        clear();
        if (bgX) {
            com.kwad.sdk.core.d.c.d("IpDirect_Helper", "is picking return");
            return;
        }
        com.kwad.sdk.core.d.c.d("IpDirect_Helper", "start pick");
        bgX = true;
        P(list);
        Q(list2);
        if (bgQ.isEmpty() && bgR.isEmpty()) {
            h hVar = (h) ServiceProvider.get(h.class);
            if (hVar == null) {
                bgX = false;
                return;
            } else {
                if (!hVar.Gd()) {
                    com.kwad.sdk.core.d.c.d("IpDirect_Helper", "isIpPreferEnable:false");
                    bgX = false;
                    return;
                }
                Rw();
            }
        }
        bgX = false;
        com.kwad.sdk.core.d.c.d("IpDirect_Helper", "end pick");
    }

    /* JADX INFO: Access modifiers changed from: private */
    public static void Ru() {
        if (Rv()) {
            return;
        }
        Rx();
    }

    private static boolean Rv() {
        List<c> list = bgQ;
        List<c> list2 = bgR;
        if (!list.isEmpty()) {
            bgU = list.get(new Random().nextInt(list.size()));
            com.kwad.sdk.core.d.c.d("IpDirect_Helper", "set from recommend:" + bgU);
            bhb = 1;
            return true;
        }
        int i = 0;
        if (list2.isEmpty()) {
            return false;
        }
        Random random = new Random();
        int weight = 0;
        for (c cVar : list2) {
            if (cVar != null) {
                weight += cVar.getWeight();
            }
        }
        if (weight <= 0) {
            return false;
        }
        int iNextInt = random.nextInt(weight);
        for (int i2 = 0; i2 < list2.size(); i2++) {
            if (list2.get(i2) != null) {
                iNextInt -= list2.get(i2).getWeight();
            }
            if (iNextInt < 0) {
                i = i2;
                break;
            }
        }
        bgU = list2.get(i);
        com.kwad.sdk.core.d.c.d("IpDirect_Helper", "set from backUp:" + bgU);
        bhb = 2;
        return true;
    }

    public static int getType() {
        return bhb;
    }

    private static void clear() {
        bgQ.clear();
        bgR.clear();
        bgS.clear();
    }

    private static void Rw() {
        List<HttpDnsInfo.IpInfo> list = bgP;
        if (list.isEmpty()) {
            return;
        }
        for (HttpDnsInfo.IpInfo ipInfo : list) {
            if (ipInfo != null && !TextUtils.isEmpty(ipInfo.ip)) {
                c cVarF = b.f(ipInfo.ip, bgL);
                if (cVarF.isSuccess()) {
                    bgS.offer(cVarF);
                }
            }
        }
        c cVarPeek = bgS.peek();
        if (cVarPeek != null) {
            bha = cVarPeek.RJ();
        }
    }

    private static void Rx() {
        if (bgS.isEmpty()) {
            return;
        }
        c cVarPeek = bgS.peek();
        if (cVarPeek.RJ() < bgL) {
            bgU = cVarPeek;
            com.kwad.sdk.core.d.c.d("IpDirect_Helper", "set from Other:" + bgU);
            bhb = 3;
        }
    }

    private static void b(List<HttpDnsInfo.IpInfo> list, List<c> list2) {
        if (list == null) {
            return;
        }
        for (HttpDnsInfo.IpInfo ipInfo : list) {
            if (ipInfo != null && !TextUtils.isEmpty(ipInfo.ip)) {
                com.kwad.sdk.core.d.c.d("IpDirect_Helper", ipInfo.toString());
                c cVarF = b.f(ipInfo.ip, bgL);
                cVarF.eR(ipInfo.weight);
                if (cVarF.isSuccess() && cVarF.RJ() < bgL) {
                    list2.add(cVarF);
                }
            }
        }
    }

    private static void P(List<HttpDnsInfo.IpInfo> list) {
        b(list, bgQ);
        if (bgQ.isEmpty()) {
            return;
        }
        Iterator<c> it = bgQ.iterator();
        float fRJ = 0.0f;
        while (it.hasNext()) {
            fRJ += it.next().RJ();
        }
        bgY = fRJ / bgQ.size();
    }

    private static void Q(List<HttpDnsInfo.IpInfo> list) {
        b(list, bgR);
        if (bgR.isEmpty()) {
            return;
        }
        int weight = 0;
        float weight2 = 0.0f;
        for (c cVar : bgR) {
            if (cVar != null) {
                weight += cVar.getWeight();
                weight2 += cVar.getWeight() * cVar.RJ();
            }
        }
        if (weight != 0) {
            bgZ = weight2 / weight;
        }
    }

    private static void Ry() {
        if (bgL == -1) {
            h hVar = (h) ServiceProvider.get(h.class);
            if (hVar != null) {
                bgL = hVar.Ge();
            } else {
                bgL = 200;
            }
        }
    }

    private static boolean Rz() {
        if (bhc) {
            com.kwad.sdk.core.d.c.d("IpDirect_Helper", "sHasNetChanged direct can not use");
            return false;
        }
        int i = bgT.get();
        com.kwad.sdk.core.d.c.d("IpDirect_Helper", "value:" + i);
        return i <= 3;
    }

    private static void RA() {
        bgT.getAndIncrement();
        com.kwad.sdk.core.d.c.d("IpDirect_Helper", "addFailedTimes:" + bgT.intValue());
    }

    public static String gK(String str) {
        if (!bgM) {
            com.kwad.sdk.core.d.c.d("IpDirect_Helper", "getIpByHost return by sIpDirectEnable false");
            return "";
        }
        if (gL(str)) {
            com.kwad.sdk.core.d.c.d("IpDirect_Helper", "isHostInvalid:false ：" + str);
            return "";
        }
        if (!Rz()) {
            com.kwad.sdk.core.d.c.d("IpDirect_Helper", "canUseIpDirect:false");
            return "";
        }
        String strRp = Rp();
        com.kwad.sdk.core.d.c.d("IpDirect_Helper", "getIpByHost ip:" + strRp);
        return strRp;
    }

    private static boolean gL(String str) {
        boolean z = !TextUtils.equals("https://" + str, i.EU());
        if (z) {
            com.kwad.sdk.core.d.c.d("IpDirect_Helper", "非核心域名 current host:" + i.EU() + "try direct host:https://" + str);
        }
        return z;
    }

    public static void RB() {
        c cVar;
        Handler handler;
        if (!bgM || (cVar = bgU) == null || TextUtils.isEmpty(cVar.getIp()) || (handler = bgW) == null) {
            return;
        }
        handler.obtainMessage(2).sendToTarget();
    }

    public static void RC() {
        RA();
        RD();
        RE();
        bhb = 0;
        Ru();
        Rt();
    }

    private static void RD() {
        HttpDnsInfo.IpInfo ipInfo;
        HttpDnsInfo.IpInfo next;
        c cVar = bgU;
        String ip = cVar == null ? "" : cVar.getIp();
        if (TextUtils.isEmpty(ip)) {
            return;
        }
        Iterator<HttpDnsInfo.IpInfo> it = bgN.iterator();
        while (true) {
            ipInfo = null;
            if (!it.hasNext()) {
                next = null;
                break;
            }
            next = it.next();
            if (next != null && TextUtils.equals(ip, next.ip)) {
                break;
            }
        }
        if (next != null) {
            bgN.remove(next);
            next = null;
        }
        for (HttpDnsInfo.IpInfo ipInfo2 : bgO) {
            if (ipInfo2 != null && TextUtils.equals(ip, ipInfo2.ip)) {
                next = ipInfo2;
                break;
            }
        }
        if (next != null) {
            bgO.remove(next);
        } else {
            ipInfo = next;
        }
        for (HttpDnsInfo.IpInfo ipInfo3 : bgP) {
            if (ipInfo3 != null && TextUtils.equals(ip, ipInfo3.ip)) {
                ipInfo = ipInfo3;
                break;
            }
        }
        if (ipInfo != null) {
            bgP.remove(ipInfo);
        }
    }

    private static void RE() {
        c next;
        if (bgU == null) {
            return;
        }
        List<c> list = bgQ;
        if (list != null && !list.isEmpty() && bgQ.contains(bgU)) {
            bgQ.remove(bgU);
            com.kwad.sdk.core.d.c.d("IpDirect_Helper", "sRecommendEntityList remove:" + bgU);
        }
        List<c> list2 = bgR;
        if (list2 != null && !list2.isEmpty()) {
            if (bgR.contains(bgU)) {
                bgR.remove(bgU);
                com.kwad.sdk.core.d.c.d("IpDirect_Helper", "sBackUpIpEntityList remove:" + bgU);
            }
            Iterator<c> it = bgR.iterator();
            while (true) {
                if (!it.hasNext()) {
                    next = null;
                    break;
                }
                next = it.next();
                if (next != null && TextUtils.equals(next.getIp(), bgU.getIp())) {
                    com.kwad.sdk.core.d.c.d("IpDirect_Helper", "set removeEntity:" + next.getIp());
                    break;
                }
            }
            if (next != null) {
                bgR.remove(next);
                com.kwad.sdk.core.d.c.d("IpDirect_Helper", "sBackUpIpEntityList remove removeEntity:" + next);
            }
        }
        c cVarPeek = bgS.peek();
        if (cVarPeek != null && cVarPeek == bgU) {
            bgS.poll();
        }
        bgU = null;
    }
}
