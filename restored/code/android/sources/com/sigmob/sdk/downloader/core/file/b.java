package com.sigmob.sdk.downloader.core.file;

import android.content.Context;
import android.net.Uri;
import android.os.Build;
import android.os.ParcelFileDescriptor;
import android.system.ErrnoException;
import android.system.Os;
import android.system.OsConstants;
import java.io.BufferedOutputStream;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.nio.channels.FileChannel;

/* JADX INFO: loaded from: classes3.dex */
public class b implements com.sigmob.sdk.downloader.core.file.a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final ParcelFileDescriptor f3434a;
    final BufferedOutputStream b;
    final FileOutputStream c;
    private final FileChannel d;

    public static class a implements com.sigmob.sdk.downloader.core.file.a.InterfaceC0563a {
        @Override // com.sigmob.sdk.downloader.core.file.a.InterfaceC0563a
        public com.sigmob.sdk.downloader.core.file.a a(Context context, Uri uri, int flushBufferSize) throws FileNotFoundException {
            return new b(context, uri, flushBufferSize);
        }

        @Override // com.sigmob.sdk.downloader.core.file.a.InterfaceC0563a
        public com.sigmob.sdk.downloader.core.file.a a(Context context, File file, int flushBufferSize) throws FileNotFoundException {
            return new b(context, Uri.fromFile(file), flushBufferSize);
        }

        @Override // com.sigmob.sdk.downloader.core.file.a.InterfaceC0563a
        public boolean a() {
            return true;
        }
    }

    public b(Context context, Uri uri, int bufferSize) throws FileNotFoundException {
        ParcelFileDescriptor parcelFileDescriptorOpenFileDescriptor = context.getContentResolver().openFileDescriptor(uri, "rw");
        if (parcelFileDescriptorOpenFileDescriptor == null) {
            throw new FileNotFoundException("result of " + uri + " is null!");
        }
        this.f3434a = parcelFileDescriptorOpenFileDescriptor;
        FileOutputStream fileOutputStream = new FileOutputStream(parcelFileDescriptorOpenFileDescriptor.getFileDescriptor());
        this.c = fileOutputStream;
        this.d = fileOutputStream.getChannel();
        this.b = new BufferedOutputStream(fileOutputStream, bufferSize);
    }

    b(FileChannel channel, ParcelFileDescriptor pdf, FileOutputStream fos, BufferedOutputStream out) {
        this.d = channel;
        this.f3434a = pdf;
        this.c = fos;
        this.b = out;
    }

    @Override // com.sigmob.sdk.downloader.core.file.a
    public void a() throws IOException {
        this.b.close();
        this.c.close();
        this.f3434a.close();
    }

    @Override // com.sigmob.sdk.downloader.core.file.a
    public void a(long offset) throws IOException {
        this.d.position(offset);
    }

    @Override // com.sigmob.sdk.downloader.core.file.a
    public void a(byte[] b, int off, int len) throws IOException {
        this.b.write(b, off, len);
    }

    @Override // com.sigmob.sdk.downloader.core.file.a
    public void b() throws IOException {
        this.b.flush();
        this.f3434a.getFileDescriptor().sync();
    }

    @Override // com.sigmob.sdk.downloader.core.file.a
    public void b(long newLength) {
        StringBuilder sb;
        try {
            Os.posix_fallocate(this.f3434a.getFileDescriptor(), 0L, newLength);
        } catch (Throwable th) {
            th = th;
            if (th instanceof ErrnoException) {
                ErrnoException errnoException = th;
                if (errnoException.errno == OsConstants.ENOSYS || errnoException.errno == OsConstants.ENOTSUP) {
                    com.sigmob.sdk.downloader.core.c.a("DownloadUriOutputStream", "fallocate() not supported; falling back to ftruncate()");
                    try {
                        Os.ftruncate(this.f3434a.getFileDescriptor(), newLength);
                        return;
                    } catch (Throwable th2) {
                        th = th2;
                        sb = new StringBuilder("It can't pre-allocate length(");
                        com.sigmob.sdk.downloader.core.c.a("DownloadUriOutputStream", sb.append(newLength).append(") on the sdk version(").append(Build.VERSION.SDK_INT).append("), because of ").append(th).toString());
                    }
                }
                return;
            }
            sb = new StringBuilder("It can't pre-allocate length(");
            com.sigmob.sdk.downloader.core.c.a("DownloadUriOutputStream", sb.append(newLength).append(") on the sdk version(").append(Build.VERSION.SDK_INT).append("), because of ").append(th).toString());
        }
    }
}
