package com.besthttp.proxy;

import java.net.InetSocketAddress;
import java.net.Proxy;
import java.net.ProxySelector;
import java.net.URI;

/* JADX INFO: loaded from: classes.dex */
public class ProxyFinder {
    public static String FindFor(String str) {
        try {
            System.setProperty("java.net.useSystemProxies", "true");
            for (Proxy proxy : ProxySelector.getDefault().select(new URI(str))) {
                InetSocketAddress inetSocketAddress = (InetSocketAddress) proxy.address();
                if (inetSocketAddress != null) {
                    return String.format("%s://%s:%s", proxy.type(), inetSocketAddress.getHostName(), Integer.valueOf(inetSocketAddress.getPort()));
                }
            }
            return null;
        } catch (Exception e) {
            e.printStackTrace();
            return null;
        }
    }
}
