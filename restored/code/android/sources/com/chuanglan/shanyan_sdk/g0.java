package com.chuanglan.shanyan_sdk;

import java.net.InetAddress;
import java.util.Iterator;
import java.util.concurrent.Callable;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.FutureTask;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.TimeoutException;

/* JADX INFO: loaded from: classes2.dex */
public class g0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private ExecutorService f1969a = Executors.newSingleThreadExecutor();

    class a implements Callable {
        a() {
        }

        @Override // java.util.concurrent.Callable
        /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
        public String call() {
            Iterator it = AbstractC0606l.M.iterator();
            while (it.hasNext()) {
                String strA = g0.this.a((String) it.next());
                if (strA != null) {
                    return strA;
                }
            }
            return "sy.cl2m.cn";
        }
    }

    public String b() {
        try {
            FutureTask futureTaskA = a();
            this.f1969a.execute(futureTaskA);
            return (String) futureTaskA.get(2L, TimeUnit.SECONDS);
        } catch (TimeoutException e) {
            Q.d("PreFetchDnsShanYanLogger", "preFetchDnsMethod  TimeoutException=", e);
            return "sy.cl2m.cn";
        } catch (Exception e2) {
            Q.d("PreFetchDnsShanYanLogger", "preFetchDnsMethod  Exception_e=", e2);
            return "sy.cl2m.cn";
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public synchronized String a(String str) {
        long jCurrentTimeMillis = System.currentTimeMillis();
        try {
            InetAddress[] allByName = InetAddress.getAllByName(str);
            if (allByName != null) {
                for (InetAddress inetAddress : allByName) {
                    if (inetAddress != null) {
                        String hostAddress = inetAddress.getHostAddress();
                        if (!"0.0.0.0".equals(hostAddress) && !"255.255.255.255".equals(hostAddress) && !"127.0.0.1".equals(hostAddress) && !"224.0.0.1".equals(hostAddress) && !hostAddress.startsWith("169.254.") && !hostAddress.contains(" ") && !hostAddress.startsWith("::")) {
                            Q.c("PreFetchDnsShanYanLogger", "getDomainName init domainName", str);
                            return str;
                        }
                        Q.c("PreFetchDnsShanYanLogger", "getDomainName name", str);
                    }
                }
            }
        } catch (Throwable th) {
            Q.d("PreFetchDnsShanYanLogger", "getDomainName  Exception_e=", th, "__耗时", Long.valueOf(System.currentTimeMillis() - jCurrentTimeMillis));
        }
        return null;
    }

    private FutureTask a() {
        return new FutureTask(new a());
    }
}
