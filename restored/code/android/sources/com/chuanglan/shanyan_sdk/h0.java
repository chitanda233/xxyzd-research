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
public class h0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private ExecutorService f1971a = Executors.newSingleThreadExecutor();

    class a implements Callable {
        a() {
        }

        @Override // java.util.concurrent.Callable
        /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
        public String call() {
            Iterator it = AbstractC0606l.N.iterator();
            while (it.hasNext()) {
                String strA = h0.this.a((String) it.next());
                if (strA != null) {
                    return strA;
                }
            }
            return "sysdk.cl2009.com";
        }
    }

    public String b() {
        try {
            FutureTask futureTaskA = a();
            this.f1971a.execute(futureTaskA);
            return (String) futureTaskA.get(2L, TimeUnit.SECONDS);
        } catch (TimeoutException e) {
            Q.d("PreFetchDnsShanYanLogger", "preFetchLogDnsMethod  TimeoutException=", e);
            return "sysdk.cl2009.com";
        } catch (Exception e2) {
            Q.d("PreFetchDnsShanYanLogger", "preFetchDnsMethod  Exception_e=", e2);
            return "sysdk.cl2009.com";
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public synchronized String a(String str) {
        String hostAddress;
        long jCurrentTimeMillis = System.currentTimeMillis();
        try {
            InetAddress[] allByName = InetAddress.getAllByName(str);
            if (allByName != null) {
                for (InetAddress inetAddress : allByName) {
                    if (inetAddress != null && (hostAddress = inetAddress.getHostAddress()) != null) {
                        if (!"0.0.0.0".equals(hostAddress) && !"255.255.255.255".equals(hostAddress) && !"127.0.0.1".equals(hostAddress) && !"224.0.0.1".equals(hostAddress) && !hostAddress.startsWith("169.254.") && !hostAddress.contains(" ") && !hostAddress.startsWith("::")) {
                            Q.c("PreFetchDnsShanYanLogger", "getDomainName log domainName", str);
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
