package com.chuanglan.shanyan_sdk;

import java.net.InetAddress;
import java.util.concurrent.Callable;
import java.util.concurrent.FutureTask;

/* JADX INFO: loaded from: classes2.dex */
public class i0 {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final String[] f1973a = {"www.cmpassport.com", "ecm.cmpassport.com", "onekey.cmpassport.com", "onekey1.cmpassport.com", "onekey2.cmpassport.com", "auth.wosms.cn", "msv6.wosms.cn", "card.e.189.cn", "id6.me"};

    class a implements Callable {
        a() {
        }

        @Override // java.util.concurrent.Callable
        /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
        public Void call() {
            for (String str : i0.this.f1973a) {
                i0.this.a(str);
            }
            return null;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str) {
        try {
            InetAddress[] allByName = InetAddress.getAllByName(str);
            if (allByName != null) {
                for (InetAddress inetAddress : allByName) {
                    if (inetAddress != null) {
                        Q.c("PreFetchDnsShanYanLogger", "getDomainName inetAddress", inetAddress, "ip", inetAddress.getHostAddress());
                    }
                }
            }
        } catch (Throwable th) {
            Q.d("PreFetchDnsShanYanLogger", "getDomainName Exception", th);
        }
    }

    public FutureTask a() {
        try {
            return new FutureTask(new a());
        } catch (Exception e) {
            Q.d("PreFetchDnsShanYanLogger", "preFetchDns Exception", e);
            return null;
        }
    }
}
