package com.sigmob.sdk.videocache;

import java.io.IOException;
import java.net.Proxy;
import java.net.ProxySelector;
import java.net.SocketAddress;
import java.net.URI;
import java.util.Arrays;
import java.util.List;

/* JADX INFO: loaded from: classes4.dex */
class j extends ProxySelector {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final List<Proxy> f3671a = Arrays.asList(Proxy.NO_PROXY);
    private final ProxySelector b;
    private final String c;
    private final int d;

    j(ProxySelector defaultProxySelector, String hostToIgnore, int portToIgnore) {
        this.b = (ProxySelector) n.a(defaultProxySelector);
        this.c = (String) n.a(hostToIgnore);
        this.d = portToIgnore;
    }

    static void a(String hostToIgnore, int portToIgnore) {
        ProxySelector.setDefault(new j(ProxySelector.getDefault(), hostToIgnore, portToIgnore));
    }

    @Override // java.net.ProxySelector
    public void connectFailed(URI uri, SocketAddress address, IOException failure) {
        this.b.connectFailed(uri, address, failure);
    }

    @Override // java.net.ProxySelector
    public List<Proxy> select(URI uri) {
        return this.c.equals(uri.getHost()) && this.d == uri.getPort() ? f3671a : this.b.select(uri);
    }
}
