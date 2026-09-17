package com.sigmob.sdk.downloader.core.download;

import java.io.IOException;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/* JADX INFO: loaded from: classes3.dex */
public class c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static final String f3422a = "ConnectTrial";
    private static final Pattern i = Pattern.compile("attachment;\\s*filename\\s*=\\s*\"([^\"]*)\"");
    private static final Pattern j = Pattern.compile("attachment;\\s*filename\\s*=\\s*(.*)");
    private final com.sigmob.sdk.downloader.f b;
    private final com.sigmob.sdk.downloader.core.breakpoint.c c;
    private boolean d;
    private long e;
    private String f;
    private String g;
    private int h;

    public c(com.sigmob.sdk.downloader.f task, com.sigmob.sdk.downloader.core.breakpoint.c info) {
        this.b = task;
        this.c = info;
    }

    private static String a(String contentDisposition) throws IOException {
        String strGroup;
        if (contentDisposition == null) {
            return null;
        }
        try {
            Matcher matcher = i.matcher(contentDisposition);
            if (matcher.find()) {
                strGroup = matcher.group(1);
            } else {
                Matcher matcher2 = j.matcher(contentDisposition);
                strGroup = matcher2.find() ? matcher2.group(1) : null;
            }
            if (strGroup != null && strGroup.contains("../")) {
                throw new com.sigmob.sdk.downloader.core.exception.a("The filename [" + strGroup + "] from the response is not allowable, because it contains '../', which can raise the directory traversal vulnerability");
            }
            return strGroup;
        } catch (IllegalStateException unused) {
            return null;
        }
    }

    private static boolean a(com.sigmob.sdk.downloader.core.connection.a.InterfaceC0560a connected) throws IOException {
        if (connected.d() == 206) {
            return true;
        }
        return "bytes".equals(connected.c(com.sigmob.sdk.downloader.core.c.i));
    }

    private static String b(com.sigmob.sdk.downloader.core.connection.a.InterfaceC0560a connected) throws IOException {
        return a(connected.c(com.sigmob.sdk.downloader.core.c.j));
    }

    private static boolean b(String transferEncoding) {
        return transferEncoding != null && transferEncoding.equals("chunked");
    }

    private static long c(String contentRange) {
        if (contentRange == null) {
            return -1L;
        }
        String[] strArrSplit = contentRange.split("/");
        if (strArrSplit.length >= 2) {
            try {
                return Long.parseLong(strArrSplit[1]);
            } catch (NumberFormatException unused) {
                com.sigmob.sdk.downloader.core.c.a(f3422a, "parse instance length failed with " + contentRange);
            }
        }
        return -1L;
    }

    private static String c(com.sigmob.sdk.downloader.core.connection.a.InterfaceC0560a connected) {
        return connected.c(com.sigmob.sdk.downloader.core.c.g);
    }

    private static long d(com.sigmob.sdk.downloader.core.connection.a.InterfaceC0560a connected) {
        long jC = c(connected.c(com.sigmob.sdk.downloader.core.c.f));
        if (jC != -1) {
            return jC;
        }
        if (!b(connected.c(com.sigmob.sdk.downloader.core.c.h))) {
            com.sigmob.sdk.downloader.core.c.a(f3422a, "Transfer-Encoding isn't chunked but there is no valid instance length found either!");
        }
        return -1L;
    }

    public void a() throws IOException {
        com.sigmob.sdk.downloader.g.j().g().b(this.b);
        com.sigmob.sdk.downloader.g.j().g().b();
        com.sigmob.sdk.downloader.core.connection.a aVarA = com.sigmob.sdk.downloader.g.j().d().a(this.b.i());
        try {
            if (!com.sigmob.sdk.downloader.core.c.a((CharSequence) this.c.k())) {
                aVarA.a(com.sigmob.sdk.downloader.core.c.c, this.c.k());
            }
            aVarA.a(com.sigmob.sdk.downloader.core.c.b, "bytes=0-0");
            Map<String, List<String>> mapB = this.b.b();
            if (mapB != null) {
                com.sigmob.sdk.downloader.core.c.a(mapB, aVarA);
            }
            com.sigmob.sdk.downloader.c cVarA = com.sigmob.sdk.downloader.g.j().b().a();
            cVarA.a(this.b, aVarA.c());
            com.sigmob.sdk.downloader.core.connection.a.InterfaceC0560a interfaceC0560aA = aVarA.a();
            this.b.a(interfaceC0560aA.g());
            com.sigmob.sdk.downloader.core.c.b(f3422a, "task[" + this.b.c() + "] redirect location: " + this.b.j());
            this.h = interfaceC0560aA.d();
            this.d = a(interfaceC0560aA);
            this.e = d(interfaceC0560aA);
            this.f = c(interfaceC0560aA);
            this.g = b(interfaceC0560aA);
            Map<String, List<String>> mapF = interfaceC0560aA.f();
            if (mapF == null) {
                mapF = new HashMap<>();
            }
            cVarA.a(this.b, this.h, mapF);
            boolean zA = a(this.e, interfaceC0560aA);
            aVarA.b();
            if (zA) {
                i();
            }
        } catch (Throwable th) {
            aVarA.b();
            throw th;
        }
    }

    boolean a(long oldInstanceLength, com.sigmob.sdk.downloader.core.connection.a.InterfaceC0560a connected) {
        String strC;
        if (oldInstanceLength != -1) {
            return false;
        }
        String strC2 = connected.c(com.sigmob.sdk.downloader.core.c.f);
        return (strC2 == null || strC2.length() <= 0) && !b(connected.c(com.sigmob.sdk.downloader.core.c.h)) && (strC = connected.c(com.sigmob.sdk.downloader.core.c.e)) != null && strC.length() > 0;
    }

    public long b() {
        return this.e;
    }

    public boolean c() {
        return this.d;
    }

    public boolean d() {
        return this.e == -1;
    }

    public String e() {
        return this.f;
    }

    public String f() {
        return this.g;
    }

    public int g() {
        return this.h;
    }

    public boolean h() {
        return (this.c.k() == null || this.c.k().equals(this.f)) ? false : true;
    }

    void i() throws IOException {
        com.sigmob.sdk.downloader.core.connection.a aVarA = com.sigmob.sdk.downloader.g.j().d().a(this.b.i());
        com.sigmob.sdk.downloader.c cVarA = com.sigmob.sdk.downloader.g.j().b().a();
        try {
            aVarA.a(com.sigmob.sdk.downloader.core.c.f3394a);
            Map<String, List<String>> mapB = this.b.b();
            if (mapB != null) {
                com.sigmob.sdk.downloader.core.c.a(mapB, aVarA);
            }
            cVarA.a(this.b, aVarA.c());
            com.sigmob.sdk.downloader.core.connection.a.InterfaceC0560a interfaceC0560aA = aVarA.a();
            cVarA.a(this.b, interfaceC0560aA.d(), interfaceC0560aA.f());
            this.e = com.sigmob.sdk.downloader.core.c.b(interfaceC0560aA.c(com.sigmob.sdk.downloader.core.c.e));
        } finally {
            aVarA.b();
        }
    }
}
