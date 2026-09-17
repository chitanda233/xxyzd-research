package cn.thinkingdata.analytics.h;

import cn.thinkingdata.analytics.TDConfig;
import cn.thinkingdata.core.receiver.TDAnalyticsObservable;
import java.util.Date;
import java.util.TimeZone;
import java.util.concurrent.locks.ReentrantReadWriteLock;

/* JADX INFO: loaded from: classes.dex */
public class a {
    private static d b;
    private static final ReentrantReadWriteLock c = new ReentrantReadWriteLock();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final TDConfig f112a;

    public a(TDConfig tDConfig) {
        this.f112a = tDConfig;
    }

    public static void a(long j) {
        a(new i(j));
        TDAnalyticsObservable.getInstance().onTimeCalibrated();
    }

    private static void a(d dVar) {
        ReentrantReadWriteLock reentrantReadWriteLock = c;
        reentrantReadWriteLock.writeLock().lock();
        b = dVar;
        reentrantReadWriteLock.writeLock().unlock();
    }

    public static void a(String... strArr) {
        if (strArr == null) {
            return;
        }
        a(new j(strArr));
    }

    public static d b() {
        return b;
    }

    public e a() {
        ReentrantReadWriteLock reentrantReadWriteLock = c;
        reentrantReadWriteLock.readLock().lock();
        d dVar = b;
        e oVar = dVar != null ? new o(dVar, this.f112a.getDefaultTimeZone()) : new n(new Date(), this.f112a.getDefaultTimeZone());
        reentrantReadWriteLock.readLock().unlock();
        return oVar;
    }

    public e a(Date date, TimeZone timeZone) {
        if (timeZone == null) {
            n nVar = new n(date, this.f112a.getDefaultTimeZone());
            nVar.c();
            return nVar;
        }
        n nVar2 = new n(date, timeZone);
        nVar2.a(true);
        return nVar2;
    }
}
